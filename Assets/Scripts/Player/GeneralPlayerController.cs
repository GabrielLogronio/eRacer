using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.InputSystem;

using Photon.Pun;

public class GeneralPlayerController : MonoBehaviourPun
{
    #region Character attributes

    [Header("Acceleration")]
    [Tooltip("Indicates how fast the racer reaches the maximum speed. [1...5]")]
    [SerializeField]
    protected float charAcceleration = 3f;


    [Header("Break")]
    [Tooltip("Indicates the reverse acceleration. [1...3]")]
    [SerializeField]
    protected float charBreak = 2f;


    [Header("Turbo")]
    [Tooltip("The multiplayer applied to the turbo. [1.5 ... 4]")]
    [SerializeField]
    protected float charTurbo = 3f;


    [Header("Max Speed")]
    [Tooltip("The maximum speed the racer can reach. [70...90]")]
    [SerializeField]
    protected float charSpeed = 75f;


    [Header("Manovrability")]
    [Tooltip("Indicates how much the vehicle can steer and the angles. [5...10]")]
    [SerializeField]
    protected float charSteer = 6f;


    [Header("Weight")]
    [Tooltip("Affects how fast the car falls back to the ground. [40...80]")]
    [SerializeField]
    protected float charWeight = 35;

    [Header("Jump Power")]
    [Tooltip("The jump power, the velocity applied. [1...5]")]
    [SerializeField]
    protected float charJump = 50f;

    [Header("Character Skills")]
    [Tooltip("The skills of the character")]
    [SerializeField]
    protected GeneralSkill[] charSkills;

    public float currentVelocity = 0f;

    #endregion

    #region Control Attributes

    protected Animator anim;
    protected PlayerInput playerInput;
    protected BoxCollider boxColl;
    protected Rigidbody controlRB;

    protected float currentAccelerationInput = 0f, currentSteerInput = 0f, currentTurbo = 1f, forwardVelocity = 0f;
    protected float maxTurbo = 1.5f, turboDuration = 2f;

    protected LayerMask groundLayer;

    protected bool grounded = false, onMaxTurbo;

    #endregion

    #region MonoBehaviour Callbacks

    protected void Awake()
    {
        SetupInput();

        anim = transform.GetChild(0).GetChild(0).GetComponent<Animator>();
        boxColl = GetComponent<BoxCollider>();
        controlRB = GetComponent<Rigidbody>();

        groundLayer = 1 << LayerMask.NameToLayer("Ground");

    }

    protected void Update()
    {
        forwardVelocity = Vector3.Dot(controlRB.velocity, transform.forward);

        if (grounded) 
        {
            transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(0f, currentSteerInput * charSteer * Time.deltaTime * forwardVelocity, 0f));
        }

        CheckGround();

        currentVelocity = controlRB.velocity.magnitude;

        /*
        if (photonView.IsMine && PhotonNetwork.IsConnected == true)
        { 
        
        }
        */
        //Debug.Log("Acc " + controlRB.velocity.magnitude);
    }

    protected void FixedUpdate()
    {
        if (currentAccelerationInput > 0)
        {
            controlRB.AddForce(transform.forward * (currentAccelerationInput + currentTurbo) * charAcceleration * 500f);
        }
        else if (currentAccelerationInput < 0)
        {
            controlRB.AddForce(transform.forward * currentAccelerationInput * currentTurbo * charBreak * 500f);
        }

        if (!grounded)
        {
            controlRB.AddForce(transform.up * charWeight * - 100f);
        }

        DampVelocity();
    }

    protected void OnEnable()
    {
        playerInput.Enable();
    }

    protected void OnDisable()
    {
        playerInput.Disable();
    }

    #endregion

    #region Utility Methods

    protected void CheckGround() 
    {
        grounded = Physics.CheckBox(boxColl.bounds.center - transform.up * boxColl.size.y / 4f, new Vector3(boxColl.size.x * 0.45f, boxColl.size.y / 3f, boxColl.size.z * 0.45f), Quaternion.identity, groundLayer);
    }

    protected void SetupInput() 
    {
        playerInput = new PlayerInput();

        playerInput.Player.Jump.performed += _ => Jump();
        playerInput.Player.Turbo.performed += _ => TurboStart();
        playerInput.Player.Turbo.canceled += _ => TurboEnd();
        playerInput.Player.MaxTurbo.performed += _ => MaxTurbo();
        playerInput.Player.Accelerate.performed += ctx => Accelerate(ctx.ReadValue<float>());
        playerInput.Player.Accelerate.canceled += ctx => Accelerate();
        playerInput.Player.Steer.performed += ctx => Steer(ctx.ReadValue<float>());
        playerInput.Player.Steer.canceled += ctx => Steer();
    }

    protected void DampVelocity() 
    { 
        Vector2 horVelocity = new Vector2(controlRB.velocity.x, controlRB.velocity.z);

        if (horVelocity.magnitude > charSpeed && currentTurbo == 1f) 
        {
            if (forwardVelocity > 0)
                horVelocity = horVelocity.normalized * charSpeed;
            else
                horVelocity = horVelocity.normalized * charSpeed / 2f;

            controlRB.velocity = new Vector3(horVelocity.x, controlRB.velocity.y, horVelocity.y);
        }

    }

    #endregion

    #region Player Actions

    protected void TurboStart() 
    {
        currentTurbo = charTurbo;
    }

    protected void TurboEnd()
    {
        currentTurbo = 1f;
    }

    protected void MaxTurbo()
    {
        Vector2 horVelocity = new Vector2(controlRB.velocity.x, controlRB.velocity.z);
        horVelocity *= maxTurbo;
        controlRB.velocity = new Vector3(horVelocity.x, controlRB.velocity.y, horVelocity.y);

        charSpeed *= maxTurbo;
        charAcceleration *= maxTurbo;

        onMaxTurbo = true;

        Invoke("EndTurbo", turboDuration);
    }

    protected void EndTurbo() 
    {
        onMaxTurbo = false;
        charSpeed /= maxTurbo;
        charAcceleration /= maxTurbo;
    }

    protected void Jump() 
    {
        if (grounded) controlRB.velocity = new Vector3(controlRB.velocity.x, charJump, controlRB.velocity.z);
    }

    protected void Accelerate(float direction) 
    {
        currentAccelerationInput = direction;
    }

    protected void Accelerate()
    {
        currentAccelerationInput = 0f;
    }

    protected void Steer(float direction)
    {
        currentSteerInput = direction;
    }

    protected void Steer()
    {
        currentSteerInput = 0f;
    }

    #endregion

}
