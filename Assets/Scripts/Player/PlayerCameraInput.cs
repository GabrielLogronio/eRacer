// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Player/PlayerCameraInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerCameraInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerCameraInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerCameraInput"",
    ""maps"": [
        {
            ""name"": ""PlayerCamera"",
            ""id"": ""6d243c32-ddf1-451c-ae30-6040725a98c3"",
            ""actions"": [
                {
                    ""name"": ""Center"",
                    ""type"": ""Button"",
                    ""id"": ""51c284af-ddda-4dc6-9776-29a8ebf6f4d3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Aim"",
                    ""type"": ""Button"",
                    ""id"": ""8123a9b8-15a0-45aa-9fc8-422d34c88b40"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""e9f3c120-95f6-4e09-b354-ff64cefe7f84"",
                    ""path"": ""<Mouse>/middleButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse+Keyboard"",
                    ""action"": ""Center"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""167fde61-0f40-4bc3-820e-27a51b8a6f94"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": ""Hold(duration=0.1)"",
                    ""processors"": """",
                    ""groups"": ""Mouse+Keyboard"",
                    ""action"": ""Aim"",
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
        }
    ]
}");
        // PlayerCamera
        m_PlayerCamera = asset.FindActionMap("PlayerCamera", throwIfNotFound: true);
        m_PlayerCamera_Center = m_PlayerCamera.FindAction("Center", throwIfNotFound: true);
        m_PlayerCamera_Aim = m_PlayerCamera.FindAction("Aim", throwIfNotFound: true);
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

    // PlayerCamera
    private readonly InputActionMap m_PlayerCamera;
    private IPlayerCameraActions m_PlayerCameraActionsCallbackInterface;
    private readonly InputAction m_PlayerCamera_Center;
    private readonly InputAction m_PlayerCamera_Aim;
    public struct PlayerCameraActions
    {
        private @PlayerCameraInput m_Wrapper;
        public PlayerCameraActions(@PlayerCameraInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Center => m_Wrapper.m_PlayerCamera_Center;
        public InputAction @Aim => m_Wrapper.m_PlayerCamera_Aim;
        public InputActionMap Get() { return m_Wrapper.m_PlayerCamera; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerCameraActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerCameraActions instance)
        {
            if (m_Wrapper.m_PlayerCameraActionsCallbackInterface != null)
            {
                @Center.started -= m_Wrapper.m_PlayerCameraActionsCallbackInterface.OnCenter;
                @Center.performed -= m_Wrapper.m_PlayerCameraActionsCallbackInterface.OnCenter;
                @Center.canceled -= m_Wrapper.m_PlayerCameraActionsCallbackInterface.OnCenter;
                @Aim.started -= m_Wrapper.m_PlayerCameraActionsCallbackInterface.OnAim;
                @Aim.performed -= m_Wrapper.m_PlayerCameraActionsCallbackInterface.OnAim;
                @Aim.canceled -= m_Wrapper.m_PlayerCameraActionsCallbackInterface.OnAim;
            }
            m_Wrapper.m_PlayerCameraActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Center.started += instance.OnCenter;
                @Center.performed += instance.OnCenter;
                @Center.canceled += instance.OnCenter;
                @Aim.started += instance.OnAim;
                @Aim.performed += instance.OnAim;
                @Aim.canceled += instance.OnAim;
            }
        }
    }
    public PlayerCameraActions @PlayerCamera => new PlayerCameraActions(this);
    private int m_MouseKeyboardSchemeIndex = -1;
    public InputControlScheme MouseKeyboardScheme
    {
        get
        {
            if (m_MouseKeyboardSchemeIndex == -1) m_MouseKeyboardSchemeIndex = asset.FindControlSchemeIndex("Mouse+Keyboard");
            return asset.controlSchemes[m_MouseKeyboardSchemeIndex];
        }
    }
    public interface IPlayerCameraActions
    {
        void OnCenter(InputAction.CallbackContext context);
        void OnAim(InputAction.CallbackContext context);
    }
}
