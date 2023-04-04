//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/Script/PlayerControls.inputactions
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

public partial class @PlayerControls : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""19817178-71e8-4a65-aaee-86e586562f15"",
            ""actions"": [
                {
                    ""name"": ""Directions"",
                    ""type"": ""Value"",
                    ""id"": ""82b22e45-aa9f-48b3-8e23-2e34faa76822"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Action_A"",
                    ""type"": ""Button"",
                    ""id"": ""a5cf0ce3-e2db-4681-9124-8918adc6fd9f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Action_B"",
                    ""type"": ""Button"",
                    ""id"": ""240623a9-bfe4-44bc-8071-0cc649b8cdb0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Action_C"",
                    ""type"": ""Button"",
                    ""id"": ""7f0a93ef-b291-4f4b-a7a1-fe78cc18b287"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Action_D"",
                    ""type"": ""Button"",
                    ""id"": ""839b53ac-9e09-4713-9079-4a536f4a6870"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Action_ABCD"",
                    ""type"": ""Button"",
                    ""id"": ""e3e22f43-db8f-4277-b940-9d1b65b1abcb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Action_E"",
                    ""type"": ""Button"",
                    ""id"": ""d18739c5-87f8-46b8-ab66-db17c9d125e4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""635e67f1-b559-452c-824a-99a955d8ae17"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Action_A"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7a7b0332-a700-4d20-9d0e-7ddbf543b570"",
                    ""path"": ""<Keyboard>/j"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Action_A"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""93a2b2e1-3f10-4712-bf27-ec90546a4b98"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Action_B"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""557deb21-20eb-436a-937f-934252ccc402"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Action_B"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b6cd6320-7255-436e-84ad-8806327ac887"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Action_C"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2e2a0e67-43e5-4575-9851-878bb1a424f8"",
                    ""path"": ""<Keyboard>/l"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Action_C"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1b0d76c0-2cec-4336-a3d1-0d03dfb394cd"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Action_D"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fea518a0-2fda-4372-b5f5-ef210562f627"",
                    ""path"": ""<Keyboard>/k"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Action_D"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""26859479-7b9d-444a-bbf4-b1ea0eea5863"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Action_ABCD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""5f21347e-75d2-425e-afe1-efa08f5a4092"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Directions"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""66bdfaa0-3cb3-465d-ab6e-b50d195c5546"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Directions"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""b5eb7dbc-3012-429a-a11a-3cc536ec0e8b"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Directions"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""5e84309e-4851-4947-bf02-bf5e861b9dd1"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Directions"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""ffa296c1-6b2a-4c3f-8ee5-e2ee07a1113f"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Directions"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""GamepadAnalog"",
                    ""id"": ""f13929f3-b7e1-40ea-8be5-9c203e4d9f2e"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Directions"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""ddb42075-2d95-4856-b89b-443d2f8818b9"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Directions"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""87ace064-6ce9-4d90-b2ad-86dbedbcf1f4"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Directions"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""cb2d1f1a-6656-4671-845b-baa19d2e0588"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Directions"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""b4393092-f927-490a-8558-330cbd3dc6e2"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Directions"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""GamepadDpad"",
                    ""id"": ""356402a9-9f95-45b9-bc1a-b840f1d7240d"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Directions"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""8f3278ac-3695-4bac-87c1-34e23d2b3b49"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Directions"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""173bf3c5-7d2d-43ff-882e-3eb1db421b23"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Directions"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""69528356-f84b-483b-aeec-099fd2c7d820"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Directions"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""19f362f2-4c32-4bb5-a186-fd9bf6a61628"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Directions"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""fc9fe873-3153-4953-bab1-c466eca89a29"",
                    ""path"": ""<Keyboard>/o"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Action_E"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""739bc90e-1564-4209-9292-75d10750a205"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Action_E"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Directions = m_Player.FindAction("Directions", throwIfNotFound: true);
        m_Player_Action_A = m_Player.FindAction("Action_A", throwIfNotFound: true);
        m_Player_Action_B = m_Player.FindAction("Action_B", throwIfNotFound: true);
        m_Player_Action_C = m_Player.FindAction("Action_C", throwIfNotFound: true);
        m_Player_Action_D = m_Player.FindAction("Action_D", throwIfNotFound: true);
        m_Player_Action_ABCD = m_Player.FindAction("Action_ABCD", throwIfNotFound: true);
        m_Player_Action_E = m_Player.FindAction("Action_E", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Directions;
    private readonly InputAction m_Player_Action_A;
    private readonly InputAction m_Player_Action_B;
    private readonly InputAction m_Player_Action_C;
    private readonly InputAction m_Player_Action_D;
    private readonly InputAction m_Player_Action_ABCD;
    private readonly InputAction m_Player_Action_E;
    public struct PlayerActions
    {
        private @PlayerControls m_Wrapper;
        public PlayerActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Directions => m_Wrapper.m_Player_Directions;
        public InputAction @Action_A => m_Wrapper.m_Player_Action_A;
        public InputAction @Action_B => m_Wrapper.m_Player_Action_B;
        public InputAction @Action_C => m_Wrapper.m_Player_Action_C;
        public InputAction @Action_D => m_Wrapper.m_Player_Action_D;
        public InputAction @Action_ABCD => m_Wrapper.m_Player_Action_ABCD;
        public InputAction @Action_E => m_Wrapper.m_Player_Action_E;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Directions.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDirections;
                @Directions.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDirections;
                @Directions.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDirections;
                @Action_A.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAction_A;
                @Action_A.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAction_A;
                @Action_A.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAction_A;
                @Action_B.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAction_B;
                @Action_B.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAction_B;
                @Action_B.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAction_B;
                @Action_C.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAction_C;
                @Action_C.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAction_C;
                @Action_C.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAction_C;
                @Action_D.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAction_D;
                @Action_D.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAction_D;
                @Action_D.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAction_D;
                @Action_ABCD.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAction_ABCD;
                @Action_ABCD.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAction_ABCD;
                @Action_ABCD.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAction_ABCD;
                @Action_E.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAction_E;
                @Action_E.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAction_E;
                @Action_E.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAction_E;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Directions.started += instance.OnDirections;
                @Directions.performed += instance.OnDirections;
                @Directions.canceled += instance.OnDirections;
                @Action_A.started += instance.OnAction_A;
                @Action_A.performed += instance.OnAction_A;
                @Action_A.canceled += instance.OnAction_A;
                @Action_B.started += instance.OnAction_B;
                @Action_B.performed += instance.OnAction_B;
                @Action_B.canceled += instance.OnAction_B;
                @Action_C.started += instance.OnAction_C;
                @Action_C.performed += instance.OnAction_C;
                @Action_C.canceled += instance.OnAction_C;
                @Action_D.started += instance.OnAction_D;
                @Action_D.performed += instance.OnAction_D;
                @Action_D.canceled += instance.OnAction_D;
                @Action_ABCD.started += instance.OnAction_ABCD;
                @Action_ABCD.performed += instance.OnAction_ABCD;
                @Action_ABCD.canceled += instance.OnAction_ABCD;
                @Action_E.started += instance.OnAction_E;
                @Action_E.performed += instance.OnAction_E;
                @Action_E.canceled += instance.OnAction_E;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    public interface IPlayerActions
    {
        void OnDirections(InputAction.CallbackContext context);
        void OnAction_A(InputAction.CallbackContext context);
        void OnAction_B(InputAction.CallbackContext context);
        void OnAction_C(InputAction.CallbackContext context);
        void OnAction_D(InputAction.CallbackContext context);
        void OnAction_ABCD(InputAction.CallbackContext context);
        void OnAction_E(InputAction.CallbackContext context);
    }
}