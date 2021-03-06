//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/PlayerControl.inputactions
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

public partial class @PlayerControl : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControl()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControl"",
    ""maps"": [
        {
            ""name"": ""Spar"",
            ""id"": ""05ea938a-bc14-411c-8ad0-4631c18f7d04"",
            ""actions"": [
                {
                    ""name"": ""punch"",
                    ""type"": ""Button"",
                    ""id"": ""e01ed4a9-45fd-4c33-8acc-b3f4d60ba825"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""ff1d8385-5158-4a2b-a032-9a8ba0a654dd"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""punch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Spar
        m_Spar = asset.FindActionMap("Spar", throwIfNotFound: true);
        m_Spar_punch = m_Spar.FindAction("punch", throwIfNotFound: true);
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

    // Spar
    private readonly InputActionMap m_Spar;
    private ISparActions m_SparActionsCallbackInterface;
    private readonly InputAction m_Spar_punch;
    public struct SparActions
    {
        private @PlayerControl m_Wrapper;
        public SparActions(@PlayerControl wrapper) { m_Wrapper = wrapper; }
        public InputAction @punch => m_Wrapper.m_Spar_punch;
        public InputActionMap Get() { return m_Wrapper.m_Spar; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(SparActions set) { return set.Get(); }
        public void SetCallbacks(ISparActions instance)
        {
            if (m_Wrapper.m_SparActionsCallbackInterface != null)
            {
                @punch.started -= m_Wrapper.m_SparActionsCallbackInterface.OnPunch;
                @punch.performed -= m_Wrapper.m_SparActionsCallbackInterface.OnPunch;
                @punch.canceled -= m_Wrapper.m_SparActionsCallbackInterface.OnPunch;
            }
            m_Wrapper.m_SparActionsCallbackInterface = instance;
            if (instance != null)
            {
                @punch.started += instance.OnPunch;
                @punch.performed += instance.OnPunch;
                @punch.canceled += instance.OnPunch;
            }
        }
    }
    public SparActions @Spar => new SparActions(this);
    public interface ISparActions
    {
        void OnPunch(InputAction.CallbackContext context);
    }
}
