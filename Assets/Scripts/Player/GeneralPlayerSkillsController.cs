using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneralPlayerSkillsController : MonoBehaviour
{
    #region Character attributes

    [Header("Character Skills")]
    [Tooltip("The skills of the character")]
    [SerializeField]
    protected GeneralSkill Skill1, Skill2, Skill3;

    #endregion

    #region Control Variables

    protected Animator anim;
    protected PlayerSkillsInput playerSkillsInput;
    protected BoxCollider boxColl;
    protected Rigidbody controlRB;

    #endregion

    #region MonoBehaviour Callbacks

    protected void Awake()
    {
        SetupInput();

        anim = transform.GetChild(0).GetChild(0).GetComponent<Animator>();
        boxColl = GetComponent<BoxCollider>();
        controlRB = GetComponent<Rigidbody>();

        Skill1.Unlock();
    }

    protected void OnEnable()
    {
        playerSkillsInput.Enable();
    }

    protected void OnDisable()
    {
        playerSkillsInput.Disable();
    }

    #endregion

    #region Utility Methods

    protected void SetupInput()
    {
        playerSkillsInput = new PlayerSkillsInput();

        playerSkillsInput.SkillsController.Skill1.performed += _ => Skill1Pressed();
        playerSkillsInput.SkillsController.Skill1.canceled += _ => Skill1Released();
        playerSkillsInput.SkillsController.Skill2.performed += _ => Skill2Pressed();
        playerSkillsInput.SkillsController.Skill2.canceled += _ => Skill2Released();
        playerSkillsInput.SkillsController.Skill3.performed += _ => Skill3Pressed();
        playerSkillsInput.SkillsController.Skill3.canceled += _ => Skill3Released();

    }

    #endregion

    #region Player Actions


    protected void Skill1Pressed()
    {
        Skill1.Activate();
    }

    protected void Skill1Released()
    {
        Skill1.Deactivate();
    }

    protected void Skill2Pressed()
    {
        Skill2.Activate();
    }

    protected void Skill2Released()
    {
        Skill2.Deactivate();
    }

    protected void Skill3Pressed()
    {
        Skill3.Activate();
    }

    protected void Skill3Released()
    {
        Skill3.Deactivate();
    }

    #endregion

}
