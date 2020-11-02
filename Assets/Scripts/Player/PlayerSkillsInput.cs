// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Player/PlayerSkillsInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerSkillsInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerSkillsInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerSkillsInput"",
    ""maps"": [
        {
            ""name"": ""SkillsController"",
            ""id"": ""880b80dc-553b-4b7c-8f35-d7952b365dcf"",
            ""actions"": [
                {
                    ""name"": ""Skill1"",
                    ""type"": ""Button"",
                    ""id"": ""b163540f-6ef2-4e35-b813-7a1a6bb48c52"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Skill2"",
                    ""type"": ""Button"",
                    ""id"": ""5dff8efe-69e5-4695-a03d-9eaed99d7e1b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Skill3"",
                    ""type"": ""Button"",
                    ""id"": ""b5da18b0-974b-463a-82c9-d32e0074f9eb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b7a3d70f-15b7-44a0-8f69-33b36226b5c2"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse+Keyboard"",
                    ""action"": ""Skill1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fd94467e-dd4d-4db9-97c5-3b2e69519923"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse+Keyboard"",
                    ""action"": ""Skill2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bdc0da1d-c674-4c10-8d28-98103995f5c4"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse+Keyboard"",
                    ""action"": ""Skill3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Mouse+Keyboard"",
            ""bindingGroup"": ""Mouse+Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // SkillsController
        m_SkillsController = asset.FindActionMap("SkillsController", throwIfNotFound: true);
        m_SkillsController_Skill1 = m_SkillsController.FindAction("Skill1", throwIfNotFound: true);
        m_SkillsController_Skill2 = m_SkillsController.FindAction("Skill2", throwIfNotFound: true);
        m_SkillsController_Skill3 = m_SkillsController.FindAction("Skill3", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // SkillsController
    private readonly InputActionMap m_SkillsController;
    private ISkillsControllerActions m_SkillsControllerActionsCallbackInterface;
    private readonly InputAction m_SkillsController_Skill1;
    private readonly InputAction m_SkillsController_Skill2;
    private readonly InputAction m_SkillsController_Skill3;
    public struct SkillsControllerActions
    {
        private @PlayerSkillsInput m_Wrapper;
        public SkillsControllerActions(@PlayerSkillsInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Skill1 => m_Wrapper.m_SkillsController_Skill1;
        public InputAction @Skill2 => m_Wrapper.m_SkillsController_Skill2;
        public InputAction @Skill3 => m_Wrapper.m_SkillsController_Skill3;
        public InputActionMap Get() { return m_Wrapper.m_SkillsController; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(SkillsControllerActions set) { return set.Get(); }
        public void SetCallbacks(ISkillsControllerActions instance)
        {
            if (m_Wrapper.m_SkillsControllerActionsCallbackInterface != null)
            {
                @Skill1.started -= m_Wrapper.m_SkillsControllerActionsCallbackInterface.OnSkill1;
                @Skill1.performed -= m_Wrapper.m_SkillsControllerActionsCallbackInterface.OnSkill1;
                @Skill1.canceled -= m_Wrapper.m_SkillsControllerActionsCallbackInterface.OnSkill1;
                @Skill2.started -= m_Wrapper.m_SkillsControllerActionsCallbackInterface.OnSkill2;
                @Skill2.performed -= m_Wrapper.m_SkillsControllerActionsCallbackInterface.OnSkill2;
                @Skill2.canceled -= m_Wrapper.m_SkillsControllerActionsCallbackInterface.OnSkill2;
                @Skill3.started -= m_Wrapper.m_SkillsControllerActionsCallbackInterface.OnSkill3;
                @Skill3.performed -= m_Wrapper.m_SkillsControllerActionsCallbackInterface.OnSkill3;
                @Skill3.canceled -= m_Wrapper.m_SkillsControllerActionsCallbackInterface.OnSkill3;
            }
            m_Wrapper.m_SkillsControllerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Skill1.started += instance.OnSkill1;
                @Skill1.performed += instance.OnSkill1;
                @Skill1.canceled += instance.OnSkill1;
                @Skill2.started += instance.OnSkill2;
                @Skill2.performed += instance.OnSkill2;
                @Skill2.canceled += instance.OnSkill2;
                @Skill3.started += instance.OnSkill3;
                @Skill3.performed += instance.OnSkill3;
                @Skill3.canceled += instance.OnSkill3;
            }
        }
    }
    public SkillsControllerActions @SkillsController => new SkillsControllerActions(this);
    private int m_MouseKeyboardSchemeIndex = -1;
    public InputControlScheme MouseKeyboardScheme
    {
        get
        {
            if (m_MouseKeyboardSchemeIndex == -1) m_MouseKeyboardSchemeIndex = asset.FindControlSchemeIndex("Mouse+Keyboard");
            return asset.controlSchemes[m_MouseKeyboardSchemeIndex];
        }
    }
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    public interface ISkillsControllerActions
    {
        void OnSkill1(InputAction.CallbackContext context);
        void OnSkill2(InputAction.CallbackContext context);
        void OnSkill3(InputAction.CallbackContext context);
    }
}
