using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraController : MonoBehaviour
{
    #region Public attributes

    [SerializeField]
    Vector2 mouseSensitivity;

    [SerializeField]
    GameObject cameraToFollow, racerToFollow;

    #endregion

    #region Control variables

    [SerializeField]
    Vector2 cameraInput = Vector2.zero, currentRotation = Vector2.zero;
    Vector3 racerRotation, targetRotation;

    PlayerCameraInput playerCameraInput;

    [SerializeField]
    float rotationSpeed = 15f, resetSpeed = 15f;

    bool moving = false;

    #endregion

    #region MonoBehaviour Callbacks

    private void Awake()
    {
        SetupInput();
    }

    void Update()
    {
        transform.position = cameraToFollow.transform.position;
        racerRotation = new Vector3(racerToFollow.transform.eulerAngles.x, racerToFollow.transform.eulerAngles.y, racerToFollow.transform.eulerAngles.z);

        cameraInput = new Vector2(Mouse.current.delta.x.ReadValue() * mouseSensitivity.x * Time.deltaTime, Mouse.current.delta.y.ReadValue() * mouseSensitivity.y * Time.deltaTime);

        if (cameraInput.magnitude > 0f) 
        {
            moving = true;

            currentRotation += cameraInput;
        } 
        else moving = false;

        transform.eulerAngles = new Vector3(currentRotation.y, currentRotation.x, 0f);

    }

    protected void OnEnable()
    {
        playerCameraInput.Enable();
    }

    protected void OnDisable()
    {
        playerCameraInput.Disable();
    }

    #endregion

    #region Utility methods

    protected void SetupInput()
    {
        playerCameraInput = new PlayerCameraInput();

        playerCameraInput.PlayerCamera.Center.performed += _ => CenterCamera();
        playerCameraInput.PlayerCamera.Aim.performed += _ => Aim(true);
        playerCameraInput.PlayerCamera.Aim.canceled += _ => Aim(false);

    }

    #endregion

    #region Player Actions

    void CenterCamera() 
    {
        currentRotation = new Vector2(racerRotation.y, 0f);
        transform.eulerAngles = racerRotation;// new Vector3(currentRotation.y, racerRotation.y, 0f);
    }

    void Aim(bool toSet) 
    {
        if (toSet)
        {

        }
        else 
        { 
        
        }
    }

    #endregion

}
