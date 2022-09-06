//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.2
//     from Assets/Scripts/Player/PlayerControlls.inputactions
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

public partial class @InputManager : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputManager()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControlls"",
    ""maps"": [
        {
            ""name"": ""Land"",
            ""id"": ""32c076b8-80d7-400d-b0bf-a3aa63879edb"",
            ""actions"": [
                {
                    ""name"": ""jump"",
                    ""type"": ""Button"",
                    ""id"": ""0caba56f-02d3-4a42-a265-6643f7177dae"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MoveHorizontal"",
                    ""type"": ""Value"",
                    ""id"": ""70eb96c7-450d-450a-8f23-3e805563f9f4"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""RT"",
                    ""type"": ""Button"",
                    ""id"": ""e69cef93-5d67-40df-aeb3-9c03d1aa2502"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Dashbutton"",
                    ""type"": ""Button"",
                    ""id"": ""f72d740d-51e1-42d1-9e24-590fb9a6870d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""DashDirection"",
                    ""type"": ""Value"",
                    ""id"": ""7d194a8d-2bc1-40bd-8ca8-1f225a20c87d"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""88c64965-4db1-4936-9d4c-25209cd66ce2"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ddf61dac-3d14-48c4-88ec-b27d08507110"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""ac4fc775-f4c6-4828-8829-dbe20d958e6a"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveHorizontal"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""db3c238f-cac2-4277-81ef-1d4f4a87f19c"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveHorizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""114afc23-d461-44b5-8d7e-3720d0afc0fd"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveHorizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis controller"",
                    ""id"": ""980c9797-ec07-4cf8-bfcd-bfb736d441ec"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveHorizontal"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""6529422e-7c0c-4978-94ff-31c8fbc0510f"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveHorizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""2bc354a9-0a99-41ab-8de0-1eca7ffe067b"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveHorizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""459b3678-b929-4684-b7b9-6b9da1ad4e41"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RT"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c2eb5442-812a-4774-a274-3c3e1d3a1f85"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dashbutton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""314feb3d-7018-44e1-877e-5440128c0362"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dashbutton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""aa497e28-2da9-4f42-8708-4e06f16c13ce"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DashDirection"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""cca395fa-9c72-42f0-8f56-49325fc7f6a3"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DashDirection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""cb2ad5b0-122d-45fe-9b81-246bac259e85"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DashDirection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""a6da70b9-d357-4f1f-b341-e73aa2835e75"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DashDirection"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""c3605add-2349-4f89-8bf4-1bc711dc8e7b"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DashDirection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""717d6e04-9b9f-40b3-a782-e78b2440fd8b"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DashDirection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Land
        m_Land = asset.FindActionMap("Land", throwIfNotFound: true);
        m_Land_jump = m_Land.FindAction("jump", throwIfNotFound: true);
        m_Land_MoveHorizontal = m_Land.FindAction("MoveHorizontal", throwIfNotFound: true);
        m_Land_RT = m_Land.FindAction("RT", throwIfNotFound: true);
        m_Land_Dashbutton = m_Land.FindAction("Dashbutton", throwIfNotFound: true);
        m_Land_DashDirection = m_Land.FindAction("DashDirection", throwIfNotFound: true);
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

    // Land
    private readonly InputActionMap m_Land;
    private ILandActions m_LandActionsCallbackInterface;
    private readonly InputAction m_Land_jump;
    private readonly InputAction m_Land_MoveHorizontal;
    private readonly InputAction m_Land_RT;
    private readonly InputAction m_Land_Dashbutton;
    private readonly InputAction m_Land_DashDirection;
    public struct LandActions
    {
        private @InputManager m_Wrapper;
        public LandActions(@InputManager wrapper) { m_Wrapper = wrapper; }
        public InputAction @jump => m_Wrapper.m_Land_jump;
        public InputAction @MoveHorizontal => m_Wrapper.m_Land_MoveHorizontal;
        public InputAction @RT => m_Wrapper.m_Land_RT;
        public InputAction @Dashbutton => m_Wrapper.m_Land_Dashbutton;
        public InputAction @DashDirection => m_Wrapper.m_Land_DashDirection;
        public InputActionMap Get() { return m_Wrapper.m_Land; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(LandActions set) { return set.Get(); }
        public void SetCallbacks(ILandActions instance)
        {
            if (m_Wrapper.m_LandActionsCallbackInterface != null)
            {
                @jump.started -= m_Wrapper.m_LandActionsCallbackInterface.OnJump;
                @jump.performed -= m_Wrapper.m_LandActionsCallbackInterface.OnJump;
                @jump.canceled -= m_Wrapper.m_LandActionsCallbackInterface.OnJump;
                @MoveHorizontal.started -= m_Wrapper.m_LandActionsCallbackInterface.OnMoveHorizontal;
                @MoveHorizontal.performed -= m_Wrapper.m_LandActionsCallbackInterface.OnMoveHorizontal;
                @MoveHorizontal.canceled -= m_Wrapper.m_LandActionsCallbackInterface.OnMoveHorizontal;
                @RT.started -= m_Wrapper.m_LandActionsCallbackInterface.OnRT;
                @RT.performed -= m_Wrapper.m_LandActionsCallbackInterface.OnRT;
                @RT.canceled -= m_Wrapper.m_LandActionsCallbackInterface.OnRT;
                @Dashbutton.started -= m_Wrapper.m_LandActionsCallbackInterface.OnDashbutton;
                @Dashbutton.performed -= m_Wrapper.m_LandActionsCallbackInterface.OnDashbutton;
                @Dashbutton.canceled -= m_Wrapper.m_LandActionsCallbackInterface.OnDashbutton;
                @DashDirection.started -= m_Wrapper.m_LandActionsCallbackInterface.OnDashDirection;
                @DashDirection.performed -= m_Wrapper.m_LandActionsCallbackInterface.OnDashDirection;
                @DashDirection.canceled -= m_Wrapper.m_LandActionsCallbackInterface.OnDashDirection;
            }
            m_Wrapper.m_LandActionsCallbackInterface = instance;
            if (instance != null)
            {
                @jump.started += instance.OnJump;
                @jump.performed += instance.OnJump;
                @jump.canceled += instance.OnJump;
                @MoveHorizontal.started += instance.OnMoveHorizontal;
                @MoveHorizontal.performed += instance.OnMoveHorizontal;
                @MoveHorizontal.canceled += instance.OnMoveHorizontal;
                @RT.started += instance.OnRT;
                @RT.performed += instance.OnRT;
                @RT.canceled += instance.OnRT;
                @Dashbutton.started += instance.OnDashbutton;
                @Dashbutton.performed += instance.OnDashbutton;
                @Dashbutton.canceled += instance.OnDashbutton;
                @DashDirection.started += instance.OnDashDirection;
                @DashDirection.performed += instance.OnDashDirection;
                @DashDirection.canceled += instance.OnDashDirection;
            }
        }
    }
    public LandActions @Land => new LandActions(this);
    public interface ILandActions
    {
        void OnJump(InputAction.CallbackContext context);
        void OnMoveHorizontal(InputAction.CallbackContext context);
        void OnRT(InputAction.CallbackContext context);
        void OnDashbutton(InputAction.CallbackContext context);
        void OnDashDirection(InputAction.CallbackContext context);
    }
}
