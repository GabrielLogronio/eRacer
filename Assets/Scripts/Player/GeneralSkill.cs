using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GeneralSkill : MonoBehaviour
{
    #region Skill attributes

    [Header("Cooldown")]
    [Tooltip("The minimum time between casts.")]
    [SerializeField]
    protected float cooldown = 0f;

    [Header("Range")]
    [Tooltip("The maximum distance the skill can reach.")]
    [SerializeField]
    protected float range = 0f;

    [Header("Area of Effect")]
    [Tooltip("The dimension of the area of impact.")]
    [SerializeField]
    protected float AOE = 0f;

    [Header("Maximum charges")]
    [Tooltip("How many times the skills can be casted.")]
    [SerializeField]
    protected int charges = 0;

    #endregion

    #region UI Elements

    [SerializeField]
    protected Text skillName;

    [SerializeField]
    protected Image skillImage;

    [SerializeField]
    protected GameObject descriptionPanel;

    #endregion

    #region Control Variables
    [SerializeField]
    protected float currentCooldown = 0f;
    protected int currentCharges = 0;
    protected bool unlocked = false;

    #endregion

    #region Public methods
    public void Activate() 
    {
        if (currentCooldown == 0) currentCooldown = cooldown;
    }

    public void Deactivate() 
    { 
    
    }

    public void Unlock() 
    {
        unlocked = true;
        currentCooldown = 0f;
    }

    public void ShowDescription(bool toShow) 
    {
        descriptionPanel.SetActive(toShow);
    }

    #endregion

    #region Monobehaviour Callbacks

    protected void Start()
    {
        currentCooldown = 0f;
        currentCharges = charges;

        skillImage.fillAmount = 1f;

    }

    protected void Update()
    {
        if (unlocked) 
        {
            if (currentCooldown > 0f) currentCooldown -= Time.deltaTime;
            else currentCooldown = 0f;

            skillImage.fillAmount = currentCooldown / cooldown;
        }
    }

    #endregion


}
