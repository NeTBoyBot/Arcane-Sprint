//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Develop/InputMap/PlayerInput.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @PlayerInput: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""Input"",
            ""id"": ""1d47018e-4236-4aa3-936d-835997d640b3"",
            ""actions"": [
                {
                    ""name"": ""InputAxis"",
                    ""type"": ""Value"",
                    ""id"": ""7a43e6aa-1a21-4d99-8ec5-a0ef08b53984"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""001ffba6-c6bf-4c00-b0cc-adc94b2d87b0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MouseAxis"",
                    ""type"": ""Value"",
                    ""id"": ""638552ea-715e-48f1-b861-7543507456da"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""3d8f727c-1a2c-4fa9-8283-207d692f557a"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""InputAxis"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""40e227db-bfa1-48cf-8b0b-c9fe6455b108"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""InputAxis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""d3c3edd0-6e90-48fb-9d02-3e8ec9a34d9b"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""InputAxis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""9e0df73d-85f0-4021-bf6b-957581b9bcd4"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""InputAxis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""a1b32ae7-c850-4dc7-a243-133dc4dfa47d"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""InputAxis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""31063b1d-4170-4e5a-813a-4ade32485333"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""cf8a1e69-5129-4ab4-b615-79ca3fd37b4f"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseAxis"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""a98d3d1e-b591-4335-b7a4-cfe4b98a9e7f"",
                    ""path"": ""<Mouse>/delta/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseAxis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""902ef6d6-1a91-41a3-b143-ba2e1efb5b91"",
                    ""path"": ""<Mouse>/delta/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseAxis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""037de511-552e-4635-a71b-a5f7bf88f4b8"",
                    ""path"": ""<Mouse>/delta/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseAxis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""876f5811-6c0f-4d80-b66b-e51b5ef48f34"",
                    ""path"": ""<Mouse>/delta/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseAxis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Input
        m_Input = asset.FindActionMap("Input", throwIfNotFound: true);
        m_Input_InputAxis = m_Input.FindAction("InputAxis", throwIfNotFound: true);
        m_Input_Jump = m_Input.FindAction("Jump", throwIfNotFound: true);
        m_Input_MouseAxis = m_Input.FindAction("MouseAxis", throwIfNotFound: true);
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

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Input
    private readonly InputActionMap m_Input;
    private List<IInputActions> m_InputActionsCallbackInterfaces = new List<IInputActions>();
    private readonly InputAction m_Input_InputAxis;
    private readonly InputAction m_Input_Jump;
    private readonly InputAction m_Input_MouseAxis;
    public struct InputActions
    {
        private @PlayerInput m_Wrapper;
        public InputActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @InputAxis => m_Wrapper.m_Input_InputAxis;
        public InputAction @Jump => m_Wrapper.m_Input_Jump;
        public InputAction @MouseAxis => m_Wrapper.m_Input_MouseAxis;
        public InputActionMap Get() { return m_Wrapper.m_Input; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(InputActions set) { return set.Get(); }
        public void AddCallbacks(IInputActions instance)
        {
            if (instance == null || m_Wrapper.m_InputActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_InputActionsCallbackInterfaces.Add(instance);
            @InputAxis.started += instance.OnInputAxis;
            @InputAxis.performed += instance.OnInputAxis;
            @InputAxis.canceled += instance.OnInputAxis;
            @Jump.started += instance.OnJump;
            @Jump.performed += instance.OnJump;
            @Jump.canceled += instance.OnJump;
            @MouseAxis.started += instance.OnMouseAxis;
            @MouseAxis.performed += instance.OnMouseAxis;
            @MouseAxis.canceled += instance.OnMouseAxis;
        }

        private void UnregisterCallbacks(IInputActions instance)
        {
            @InputAxis.started -= instance.OnInputAxis;
            @InputAxis.performed -= instance.OnInputAxis;
            @InputAxis.canceled -= instance.OnInputAxis;
            @Jump.started -= instance.OnJump;
            @Jump.performed -= instance.OnJump;
            @Jump.canceled -= instance.OnJump;
            @MouseAxis.started -= instance.OnMouseAxis;
            @MouseAxis.performed -= instance.OnMouseAxis;
            @MouseAxis.canceled -= instance.OnMouseAxis;
        }

        public void RemoveCallbacks(IInputActions instance)
        {
            if (m_Wrapper.m_InputActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IInputActions instance)
        {
            foreach (var item in m_Wrapper.m_InputActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_InputActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public InputActions @Input => new InputActions(this);
    public interface IInputActions
    {
        void OnInputAxis(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnMouseAxis(InputAction.CallbackContext context);
    }
}
