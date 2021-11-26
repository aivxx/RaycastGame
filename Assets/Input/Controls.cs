// GENERATED AUTOMATICALLY FROM 'Assets/Input/Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Controls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""Controller"",
            ""id"": ""98c6cd66-91ab-4020-a95d-3dda40efa8c5"",
            ""actions"": [
                {
                    ""name"": ""Fire"",
                    ""type"": ""PassThrough"",
                    ""id"": ""2a7d1d99-f101-43ba-81a4-2f41cd4adf2b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MousePosition"",
                    ""type"": ""PassThrough"",
                    ""id"": ""1dcab6fe-06a1-4874-9d1f-291c8b48cc8a"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""97a9ebe5-9eb9-42ba-9b2a-8875e22caef0"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""New control scheme"",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ef2dc14d-9b4c-48d0-9d1c-ed94a6ae37f2"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""New control scheme"",
                    ""action"": ""MousePosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Pause"",
            ""id"": ""81164daa-8c77-4e66-a772-95f1bf7e638c"",
            ""actions"": [
                {
                    ""name"": ""Paused"",
                    ""type"": ""Button"",
                    ""id"": ""460fcbb6-0dfd-4088-902f-446cdd3b8e45"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""4fa05e0d-5312-4d00-9b7a-bbfaf297b533"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""New control scheme"",
                    ""action"": ""Paused"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""New control scheme"",
            ""bindingGroup"": ""New control scheme"",
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
        }
    ]
}");
        // Controller
        m_Controller = asset.FindActionMap("Controller", throwIfNotFound: true);
        m_Controller_Fire = m_Controller.FindAction("Fire", throwIfNotFound: true);
        m_Controller_MousePosition = m_Controller.FindAction("MousePosition", throwIfNotFound: true);
        // Pause
        m_Pause = asset.FindActionMap("Pause", throwIfNotFound: true);
        m_Pause_Paused = m_Pause.FindAction("Paused", throwIfNotFound: true);
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

    // Controller
    private readonly InputActionMap m_Controller;
    private IControllerActions m_ControllerActionsCallbackInterface;
    private readonly InputAction m_Controller_Fire;
    private readonly InputAction m_Controller_MousePosition;
    public struct ControllerActions
    {
        private @Controls m_Wrapper;
        public ControllerActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Fire => m_Wrapper.m_Controller_Fire;
        public InputAction @MousePosition => m_Wrapper.m_Controller_MousePosition;
        public InputActionMap Get() { return m_Wrapper.m_Controller; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ControllerActions set) { return set.Get(); }
        public void SetCallbacks(IControllerActions instance)
        {
            if (m_Wrapper.m_ControllerActionsCallbackInterface != null)
            {
                @Fire.started -= m_Wrapper.m_ControllerActionsCallbackInterface.OnFire;
                @Fire.performed -= m_Wrapper.m_ControllerActionsCallbackInterface.OnFire;
                @Fire.canceled -= m_Wrapper.m_ControllerActionsCallbackInterface.OnFire;
                @MousePosition.started -= m_Wrapper.m_ControllerActionsCallbackInterface.OnMousePosition;
                @MousePosition.performed -= m_Wrapper.m_ControllerActionsCallbackInterface.OnMousePosition;
                @MousePosition.canceled -= m_Wrapper.m_ControllerActionsCallbackInterface.OnMousePosition;
            }
            m_Wrapper.m_ControllerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Fire.started += instance.OnFire;
                @Fire.performed += instance.OnFire;
                @Fire.canceled += instance.OnFire;
                @MousePosition.started += instance.OnMousePosition;
                @MousePosition.performed += instance.OnMousePosition;
                @MousePosition.canceled += instance.OnMousePosition;
            }
        }
    }
    public ControllerActions @Controller => new ControllerActions(this);

    // Pause
    private readonly InputActionMap m_Pause;
    private IPauseActions m_PauseActionsCallbackInterface;
    private readonly InputAction m_Pause_Paused;
    public struct PauseActions
    {
        private @Controls m_Wrapper;
        public PauseActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Paused => m_Wrapper.m_Pause_Paused;
        public InputActionMap Get() { return m_Wrapper.m_Pause; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PauseActions set) { return set.Get(); }
        public void SetCallbacks(IPauseActions instance)
        {
            if (m_Wrapper.m_PauseActionsCallbackInterface != null)
            {
                @Paused.started -= m_Wrapper.m_PauseActionsCallbackInterface.OnPaused;
                @Paused.performed -= m_Wrapper.m_PauseActionsCallbackInterface.OnPaused;
                @Paused.canceled -= m_Wrapper.m_PauseActionsCallbackInterface.OnPaused;
            }
            m_Wrapper.m_PauseActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Paused.started += instance.OnPaused;
                @Paused.performed += instance.OnPaused;
                @Paused.canceled += instance.OnPaused;
            }
        }
    }
    public PauseActions @Pause => new PauseActions(this);
    private int m_NewcontrolschemeSchemeIndex = -1;
    public InputControlScheme NewcontrolschemeScheme
    {
        get
        {
            if (m_NewcontrolschemeSchemeIndex == -1) m_NewcontrolschemeSchemeIndex = asset.FindControlSchemeIndex("New control scheme");
            return asset.controlSchemes[m_NewcontrolschemeSchemeIndex];
        }
    }
    public interface IControllerActions
    {
        void OnFire(InputAction.CallbackContext context);
        void OnMousePosition(InputAction.CallbackContext context);
    }
    public interface IPauseActions
    {
        void OnPaused(InputAction.CallbackContext context);
    }
}
