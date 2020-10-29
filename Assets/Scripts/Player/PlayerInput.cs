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
            ""name"": ""Player"",
            ""id"": ""b8bd3272-008a-4600-8eb2-c64148624d5b"",
            ""actions"": [
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""2adafc12-304d-4dfe-a2a9-6829598c8da3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""1st Skill"",
                    ""type"": ""Button"",
                    ""id"": ""3dc494b8-1574-41cd-bee8-86094c37420e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""2nd Skill"",
                    ""type"": ""Button"",
                    ""id"": ""057cc26e-5931-4fd9-a09b-3d1cd9fafcfc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""3rd Skill"",
                    ""type"": ""Button"",
                    ""id"": ""07ad19ca-2c07-4dd6-afa9-e7d4ba0701eb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
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
                    ""id"": ""4e3ba56b-f257-4ed2-8e75-e56082eb8154"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mose+Keyboard"",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""715fd6a2-c780-40f2-8828-428d3f93b8c9"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""884a0930-4ad5-4432-97d7-b60ab1b3bc8b"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mose+Keyboard"",
                    ""action"": ""1st Skill"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d6d2b1f7-eeca-4c7b-ac79-fb32ce4894cd"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""1st Skill"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""910a72d9-d755-4855-b4e4-cbedbe7efe40"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mose+Keyboard"",
                    ""action"": ""2nd Skill"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3a76fd0f-660c-47a4-ba24-114dfe10b30c"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""2nd Skill"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
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
                    ""id"": ""f4a6f561-6705-40ba-b160-2fb0d1180384"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mose+Keyboard"",
                    ""action"": ""3rd Skill"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d734a91d-c2bd-4c7e-b9b5-ca80cd4a8852"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""3rd Skill"",
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
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Shoot = m_Player.FindAction("Shoot", throwIfNotFound: true);
        m_Player__1stSkill = m_Player.FindAction("1st Skill", throwIfNotFound: true);
        m_Player__2ndSkill = m_Player.FindAction("2nd Skill", throwIfNotFound: true);
        m_Player__3rdSkill = m_Player.FindAction("3rd Skill", throwIfNotFound: true);
        m_Player_Jump = m_Player.FindAction("Jump", throwIfNotFound: true);
        m_Player_Turbo = m_Player.FindAction("Turbo", throwIfNotFound: true);
        m_Player_MaxTurbo = m_Player.FindAction("MaxTurbo", throwIfNotFound: true);
        m_Player_Accelerate = m_Player.FindAction("Accelerate", throwIfNotFound: true);
        m_Player_Steer = m_Player.FindAction("Steer", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Shoot;
    private readonly InputAction m_Player__1stSkill;
    private readonly InputAction m_Player__2ndSkill;
    private readonly InputAction m_Player__3rdSkill;
    private readonly InputAction m_Player_Jump;
    private readonly InputAction m_Player_Turbo;
    private readonly InputAction m_Player_MaxTurbo;
    private readonly InputAction m_Player_Accelerate;
    private readonly InputAction m_Player_Steer;
    public struct PlayerActions
    {
        private @PlayerInput m_Wrapper;
        public PlayerActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Shoot => m_Wrapper.m_Player_Shoot;
        public InputAction @_1stSkill => m_Wrapper.m_Player__1stSkill;
        public InputAction @_2ndSkill => m_Wrapper.m_Player__2ndSkill;
        public InputAction @_3rdSkill => m_Wrapper.m_Player__3rdSkill;
        public InputAction @Jump => m_Wrapper.m_Player_Jump;
        public InputAction @Turbo => m_Wrapper.m_Player_Turbo;
        public InputAction @MaxTurbo => m_Wrapper.m_Player_MaxTurbo;
        public InputAction @Accelerate => m_Wrapper.m_Player_Accelerate;
        public InputAction @Steer => m_Wrapper.m_Player_Steer;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Shoot.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShoot;
                @_1stSkill.started -= m_Wrapper.m_PlayerActionsCallbackInterface.On_1stSkill;
                @_1stSkill.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.On_1stSkill;
                @_1stSkill.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.On_1stSkill;
                @_2ndSkill.started -= m_Wrapper.m_PlayerActionsCallbackInterface.On_2ndSkill;
                @_2ndSkill.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.On_2ndSkill;
                @_2ndSkill.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.On_2ndSkill;
                @_3rdSkill.started -= m_Wrapper.m_PlayerActionsCallbackInterface.On_3rdSkill;
                @_3rdSkill.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.On_3rdSkill;
                @_3rdSkill.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.On_3rdSkill;
                @Jump.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Turbo.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTurbo;
                @Turbo.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTurbo;
                @Turbo.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTurbo;
                @MaxTurbo.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMaxTurbo;
                @MaxTurbo.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMaxTurbo;
                @MaxTurbo.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMaxTurbo;
                @Accelerate.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAccelerate;
                @Accelerate.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAccelerate;
                @Accelerate.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAccelerate;
                @Steer.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSteer;
                @Steer.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSteer;
                @Steer.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSteer;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
                @_1stSkill.started += instance.On_1stSkill;
                @_1stSkill.performed += instance.On_1stSkill;
                @_1stSkill.canceled += instance.On_1stSkill;
                @_2ndSkill.started += instance.On_2ndSkill;
                @_2ndSkill.performed += instance.On_2ndSkill;
                @_2ndSkill.canceled += instance.On_2ndSkill;
                @_3rdSkill.started += instance.On_3rdSkill;
                @_3rdSkill.performed += instance.On_3rdSkill;
                @_3rdSkill.canceled += instance.On_3rdSkill;
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
    public PlayerActions @Player => new PlayerActions(this);
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
    public interface IPlayerActions
    {
        void OnShoot(InputAction.CallbackContext context);
        void On_1stSkill(InputAction.CallbackContext context);
        void On_2ndSkill(InputAction.CallbackContext context);
        void On_3rdSkill(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnTurbo(InputAction.CallbackContext context);
        void OnMaxTurbo(InputAction.CallbackContext context);
        void OnAccelerate(InputAction.CallbackContext context);
        void OnSteer(InputAction.CallbackContext context);
    }
}
