// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Player/PlayerInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""PlayerMovement"",
            ""id"": ""b8bd3272-008a-4600-8eb2-c64148624d5b"",
            ""actions"": [
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""66d5c381-6145-4bb6-b125-f16bf05f3dcd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Turbo"",
                    ""type"": ""Button"",
                    ""id"": ""bd77be80-90d5-4598-8ea9-71a5885fc0e9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MaxTurbo"",
                    ""type"": ""Button"",
                    ""id"": ""85439ccd-f6e5-4482-b923-47eae0f93fc4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Accelerate"",
                    ""type"": ""Button"",
                    ""id"": ""50e0f914-2974-4e7b-9d40-fbeb0660748e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Steer"",
                    ""type"": ""Button"",
                    ""id"": ""68d4cb61-7564-45f9-9f39-0114a3134cb7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b663c1a4-778c-4b74-af19-52b4846f0906"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mose+Keyboard"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""91dde1b3-1d8c-48ab-86f5-515476b98230"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1518a5c7-8989-4464-bd3a-5ad6b8b3c716"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": ""Hold(duration=0.3)"",
                    ""processors"": """",
                    ""groups"": ""Mose+Keyboard"",
                    ""action"": ""Turbo"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2c477cf5-6b26-47da-b211-e7700b568579"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": ""Hold(duration=0.3)"",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Turbo"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a8f6fcc7-6832-41ef-a34d-f9a12d21c30b"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": ""Tap(duration=0.25)"",
                    ""processors"": """",
                    ""groups"": ""Mose+Keyboard"",
                    ""action"": ""MaxTurbo"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""58dc0f72-b645-427d-be97-5436a20cb8fb"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": ""Tap(duration=0.25)"",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""MaxTurbo"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""83dd5929-a469-429f-ab3d-dd92364bb14f"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Accelerate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""9a577d8f-584b-4808-944f-b26a6cc1dce1"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mose+Keyboard"",
                    ""action"": ""Accelerate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""c71eff82-651a-4d4d-bcc4-abe57b781936"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mose+Keyboard"",
                    ""action"": ""Accelerate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""5d8eefe9-a43e-4409-a625-50eac984059c"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Accelerate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""6517ea8b-999d-40e9-a0cc-64a5111c1cdd"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Accelerate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""999b0720-6252-4105-927c-2900283a5f09"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Accelerate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""184be7a8-b0f9-4c56-bec3-31c1caf07a0b"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steer"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""06bb5573-c95d-4cef-a980-8309f84b72b8"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mose+Keyboard"",
                    ""action"": ""Steer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""314cb4a9-9e6b-457e-aa90-e67b24cabf12"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mose+Keyboard"",
                    ""action"": ""Steer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""e3593661-ad76-4cc0-8bcc-12f9372240d3"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steer"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""3f8016ee-2df5-411a-862e-23ea0604c687"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Steer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""b36076d5-6451-4d29-81eb-e1e1494130b6"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Steer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""PlayerSkills"",
            ""id"": ""d5fb48cc-34b7-4a1b-a2f0-bc3eeb93f611"",
            ""actions"": [
                {
                    ""name"": ""FirstSkill"",
                    ""type"": ""Button"",
                    ""id"": ""91a6ff7b-e228-4d66-8dde-31fedbaeaaf4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SecondSkill"",
                    ""type"": ""Button"",
                    ""id"": ""86803aef-ac3b-4abd-9646-b221b4f460fc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ThirdSkill"",
                    ""type"": ""Button"",
                    ""id"": ""7cb11ad0-9f68-4c80-b671-909f85ed4ce1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""3d0ad7ef-036f-44e2-b28c-e9ec09d35628"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""71620b96-1a87-4101-9010-fdebc364ffa9"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mose+Keyboard"",
                    ""action"": ""FirstSkill"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""58ac9dcf-d1de-400b-b813-83d2ce9c1b58"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mose+Keyboard"",
                    ""action"": ""SecondSkill"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8fa11e20-c7e3-4e41-b627-7197074b28db"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mose+Keyboard"",
                    ""action"": ""ThirdSkill"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c2ade3ff-2456-40c1-b237-c66a574fba6d"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mose+Keyboard"",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Mose+Keyboard"",
            ""bindingGroup"": ""Mose+Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
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
        // PlayerMovement
        m_PlayerMovement = asset.FindActionMap("PlayerMovement", throwIfNotFound: true);
        m_PlayerMovement_Jump = m_PlayerMovement.FindAction("Jump", throwIfNotFound: true);
        m_PlayerMovement_Turbo = m_PlayerMovement.FindAction("Turbo", throwIfNotFound: true);
        m_PlayerMovement_MaxTurbo = m_PlayerMovement.FindAction("MaxTurbo", throwIfNotFound: true);
        m_PlayerMovement_Accelerate = m_PlayerMovement.FindAction("Accelerate", throwIfNotFound: true);
        m_PlayerMovement_Steer = m_PlayerMovement.FindAction("Steer", throwIfNotFound: true);
        // PlayerSkills
        m_PlayerSkills = asset.FindActionMap("PlayerSkills", throwIfNotFound: true);
        m_PlayerSkills_FirstSkill = m_PlayerSkills.FindAction("FirstSkill", throwIfNotFound: true);
        m_PlayerSkills_SecondSkill = m_PlayerSkills.FindAction("SecondSkill", throwIfNotFound: true);
        m_PlayerSkills_ThirdSkill = m_PlayerSkills.FindAction("ThirdSkill", throwIfNotFound: true);
        m_PlayerSkills_Shoot = m_PlayerSkills.FindAction("Shoot", throwIfNotFound: true);
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

    // PlayerMovement
    private readonly InputActionMap m_PlayerMovement;
    private IPlayerMovementActions m_PlayerMovementActionsCallbackInterface;
    private readonly InputAction m_PlayerMovement_Jump;
    private readonly InputAction m_PlayerMovement_Turbo;
    private readonly InputAction m_PlayerMovement_MaxTurbo;
    private readonly InputAction m_PlayerMovement_Accelerate;
    private readonly InputAction m_PlayerMovement_Steer;
    public struct PlayerMovementActions
    {
        private @PlayerInput m_Wrapper;
        public PlayerMovementActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Jump => m_Wrapper.m_PlayerMovement_Jump;
        public InputAction @Turbo => m_Wrapper.m_PlayerMovement_Turbo;
        public InputAction @MaxTurbo => m_Wrapper.m_PlayerMovement_MaxTurbo;
        public InputAction @Accelerate => m_Wrapper.m_PlayerMovement_Accelerate;
        public InputAction @Steer => m_Wrapper.m_PlayerMovement_Steer;
        public InputActionMap Get() { return m_Wrapper.m_PlayerMovement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerMovementActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerMovementActions instance)
        {
            if (m_Wrapper.m_PlayerMovementActionsCallbackInterface != null)
            {
                @Jump.started -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnJump;
                @Turbo.started -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnTurbo;
                @Turbo.performed -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnTurbo;
                @Turbo.canceled -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnTurbo;
                @MaxTurbo.started -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnMaxTurbo;
                @MaxTurbo.performed -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnMaxTurbo;
                @MaxTurbo.canceled -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnMaxTurbo;
                @Accelerate.started -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnAccelerate;
                @Accelerate.performed -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnAccelerate;
                @Accelerate.canceled -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnAccelerate;
                @Steer.started -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnSteer;
                @Steer.performed -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnSteer;
                @Steer.canceled -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnSteer;
            }
            m_Wrapper.m_PlayerMovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Turbo.started += instance.OnTurbo;
                @Turbo.performed += instance.OnTurbo;
                @Turbo.canceled += instance.OnTurbo;
                @MaxTurbo.started += instance.OnMaxTurbo;
                @MaxTurbo.performed += instance.OnMaxTurbo;
                @MaxTurbo.canceled += instance.OnMaxTurbo;
                @Accelerate.started += instance.OnAccelerate;
                @Accelerate.performed += instance.OnAccelerate;
                @Accelerate.canceled += instance.OnAccelerate;
                @Steer.started += instance.OnSteer;
                @Steer.performed += instance.OnSteer;
                @Steer.canceled += instance.OnSteer;
            }
        }
    }
    public PlayerMovementActions @PlayerMovement => new PlayerMovementActions(this);

    // PlayerSkills
    private readonly InputActionMap m_PlayerSkills;
    private IPlayerSkillsActions m_PlayerSkillsActionsCallbackInterface;
    private readonly InputAction m_PlayerSkills_FirstSkill;
    private readonly InputAction m_PlayerSkills_SecondSkill;
    private readonly InputAction m_PlayerSkills_ThirdSkill;
    private readonly InputAction m_PlayerSkills_Shoot;
    public struct PlayerSkillsActions
    {
        private @PlayerInput m_Wrapper;
        public PlayerSkillsActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @FirstSkill => m_Wrapper.m_PlayerSkills_FirstSkill;
        public InputAction @SecondSkill => m_Wrapper.m_PlayerSkills_SecondSkill;
        public InputAction @ThirdSkill => m_Wrapper.m_PlayerSkills_ThirdSkill;
        public InputAction @Shoot => m_Wrapper.m_PlayerSkills_Shoot;
        public InputActionMap Get() { return m_Wrapper.m_PlayerSkills; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerSkillsActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerSkillsActions instance)
        {
            if (m_Wrapper.m_PlayerSkillsActionsCallbackInterface != null)
            {
                @FirstSkill.started -= m_Wrapper.m_PlayerSkillsActionsCallbackInterface.OnFirstSkill;
                @FirstSkill.performed -= m_Wrapper.m_PlayerSkillsActionsCallbackInterface.OnFirstSkill;
                @FirstSkill.canceled -= m_Wrapper.m_PlayerSkillsActionsCallbackInterface.OnFirstSkill;
                @SecondSkill.started -= m_Wrapper.m_PlayerSkillsActionsCallbackInterface.OnSecondSkill;
                @SecondSkill.performed -= m_Wrapper.m_PlayerSkillsActionsCallbackInterface.OnSecondSkill;
                @SecondSkill.canceled -= m_Wrapper.m_PlayerSkillsActionsCallbackInterface.OnSecondSkill;
                @ThirdSkill.started -= m_Wrapper.m_PlayerSkillsActionsCallbackInterface.OnThirdSkill;
                @ThirdSkill.performed -= m_Wrapper.m_PlayerSkillsActionsCallbackInterface.OnThirdSkill;
                @ThirdSkill.canceled -= m_Wrapper.m_PlayerSkillsActionsCallbackInterface.OnThirdSkill;
                @Shoot.started -= m_Wrapper.m_PlayerSkillsActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_PlayerSkillsActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_PlayerSkillsActionsCallbackInterface.OnShoot;
            }
            m_Wrapper.m_PlayerSkillsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @FirstSkill.started += instance.OnFirstSkill;
                @FirstSkill.performed += instance.OnFirstSkill;
                @FirstSkill.canceled += instance.OnFirstSkill;
                @SecondSkill.started += instance.OnSecondSkill;
                @SecondSkill.performed += instance.OnSecondSkill;
                @SecondSkill.canceled += instance.OnSecondSkill;
                @ThirdSkill.started += instance.OnThirdSkill;
                @ThirdSkill.performed += instance.OnThirdSkill;
                @ThirdSkill.canceled += instance.OnThirdSkill;
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
            }
        }
    }
    public PlayerSkillsActions @PlayerSkills => new PlayerSkillsActions(this);
    private int m_MoseKeyboardSchemeIndex = -1;
    public InputControlScheme MoseKeyboardScheme
    {
        get
        {
            if (m_MoseKeyboardSchemeIndex == -1) m_MoseKeyboardSchemeIndex = asset.FindControlSchemeIndex("Mose+Keyboard");
            return asset.controlSchemes[m_MoseKeyboardSchemeIndex];
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
    public interface IPlayerMovementActions
    {
        void OnJump(InputAction.CallbackContext context);
        void OnTurbo(InputAction.CallbackContext context);
        void OnMaxTurbo(InputAction.CallbackContext context);
        void OnAccelerate(InputAction.CallbackContext context);
        void OnSteer(InputAction.CallbackContext context);
    }
    public interface IPlayerSkillsActions
    {
        void OnFirstSkill(InputAction.CallbackContext context);
        void OnSecondSkill(InputAction.CallbackContext context);
        void OnThirdSkill(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
    }
}
