// GENERATED AUTOMATICALLY FROM 'Assets/myCons.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @MyCons : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @MyCons()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""myCons"",
    ""maps"": [
        {
            ""name"": ""TPS"",
            ""id"": ""81e260b7-a5fb-4b7b-ad0b-d88c282b2f2c"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""77f96afb-9ebb-4325-8a27-6774b893b9cd"",
                    ""expectedControlType"": ""Stick"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""c7d6c3c8-6146-4193-8c23-42ac1f4b938d"",
                    ""expectedControlType"": ""Stick"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Fire"",
                    ""type"": ""Button"",
                    ""id"": ""58ff6fb6-2658-4370-92dd-ebf5de7f6088"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""5e4d71ba-fe0c-45fe-a5e9-36f03afd6931"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""91bc5db0-b63c-4e49-a040-ce29b7b1f5b8"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""97fc6d9b-b307-4f80-8bcb-3c3553ec7f88"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""2c873bca-4360-4ef3-a141-12da3a2d7329"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""270ff2fe-e400-4de5-abb2-6a214ed52d6b"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""99b57405-b907-4ba6-90c8-8f9528f89766"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""360500b5-9ad8-4b3c-99d8-f6d79b746c29"",
                    ""path"": ""<Gamepad>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""8b4841e1-2fc5-4f13-bf43-7d69d55a5b62"",
                    ""path"": ""<Gamepad>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""ec3346fc-19d8-4398-8fb8-761522334400"",
                    ""path"": ""<Gamepad>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""e6e3c7c5-b71b-4351-aa9e-5a4f4c46402a"",
                    ""path"": ""<Gamepad>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""9cd1c0ae-2810-46e4-9f11-0b354fd7b675"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // TPS
        m_TPS = asset.FindActionMap("TPS", throwIfNotFound: true);
        m_TPS_Move = m_TPS.FindAction("Move", throwIfNotFound: true);
        m_TPS_Look = m_TPS.FindAction("Look", throwIfNotFound: true);
        m_TPS_Fire = m_TPS.FindAction("Fire", throwIfNotFound: true);
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

    // TPS
    private readonly InputActionMap m_TPS;
    private ITPSActions m_TPSActionsCallbackInterface;
    private readonly InputAction m_TPS_Move;
    private readonly InputAction m_TPS_Look;
    private readonly InputAction m_TPS_Fire;
    public struct TPSActions
    {
        private @MyCons m_Wrapper;
        public TPSActions(@MyCons wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_TPS_Move;
        public InputAction @Look => m_Wrapper.m_TPS_Look;
        public InputAction @Fire => m_Wrapper.m_TPS_Fire;
        public InputActionMap Get() { return m_Wrapper.m_TPS; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TPSActions set) { return set.Get(); }
        public void SetCallbacks(ITPSActions instance)
        {
            if (m_Wrapper.m_TPSActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_TPSActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_TPSActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_TPSActionsCallbackInterface.OnMove;
                @Look.started -= m_Wrapper.m_TPSActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_TPSActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_TPSActionsCallbackInterface.OnLook;
                @Fire.started -= m_Wrapper.m_TPSActionsCallbackInterface.OnFire;
                @Fire.performed -= m_Wrapper.m_TPSActionsCallbackInterface.OnFire;
                @Fire.canceled -= m_Wrapper.m_TPSActionsCallbackInterface.OnFire;
            }
            m_Wrapper.m_TPSActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @Fire.started += instance.OnFire;
                @Fire.performed += instance.OnFire;
                @Fire.canceled += instance.OnFire;
            }
        }
    }
    public TPSActions @TPS => new TPSActions(this);
    public interface ITPSActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnFire(InputAction.CallbackContext context);
    }
}
