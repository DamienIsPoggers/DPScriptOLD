//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/Script/InputActions/DebugShit.inputactions
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

public partial class @DebugShit : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @DebugShit()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""DebugShit"",
    ""maps"": [
        {
            ""name"": ""Debug"",
            ""id"": ""c12add88-9231-4332-9365-b7d8bef64acb"",
            ""actions"": [
                {
                    ""name"": ""DebugMenu"",
                    ""type"": ""Button"",
                    ""id"": ""71d57b90-215c-499c-bbaa-01c99e3170ee"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""7eae925f-7965-495b-9e23-d2ecacc75286"",
                    ""path"": ""<Keyboard>/f1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DebugMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Debug
        m_Debug = asset.FindActionMap("Debug", throwIfNotFound: true);
        m_Debug_DebugMenu = m_Debug.FindAction("DebugMenu", throwIfNotFound: true);
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

    // Debug
    private readonly InputActionMap m_Debug;
    private IDebugActions m_DebugActionsCallbackInterface;
    private readonly InputAction m_Debug_DebugMenu;
    public struct DebugActions
    {
        private @DebugShit m_Wrapper;
        public DebugActions(@DebugShit wrapper) { m_Wrapper = wrapper; }
        public InputAction @DebugMenu => m_Wrapper.m_Debug_DebugMenu;
        public InputActionMap Get() { return m_Wrapper.m_Debug; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DebugActions set) { return set.Get(); }
        public void SetCallbacks(IDebugActions instance)
        {
            if (m_Wrapper.m_DebugActionsCallbackInterface != null)
            {
                @DebugMenu.started -= m_Wrapper.m_DebugActionsCallbackInterface.OnDebugMenu;
                @DebugMenu.performed -= m_Wrapper.m_DebugActionsCallbackInterface.OnDebugMenu;
                @DebugMenu.canceled -= m_Wrapper.m_DebugActionsCallbackInterface.OnDebugMenu;
            }
            m_Wrapper.m_DebugActionsCallbackInterface = instance;
            if (instance != null)
            {
                @DebugMenu.started += instance.OnDebugMenu;
                @DebugMenu.performed += instance.OnDebugMenu;
                @DebugMenu.canceled += instance.OnDebugMenu;
            }
        }
    }
    public DebugActions @Debug => new DebugActions(this);
    public interface IDebugActions
    {
        void OnDebugMenu(InputAction.CallbackContext context);
    }
}
