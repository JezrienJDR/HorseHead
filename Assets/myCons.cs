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
                },
                {
                    ""name"": ""NextAbility"",
                    ""type"": ""Button"",
                    ""id"": ""ddef27e2-e47e-4aef-8a1b-8587e89c22d4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PrevAbility"",
                    ""type"": ""Button"",
                    ""id"": ""67731139-ffc6-48d1-988e-4ecdd7929e49"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""UseAbility"",
                    ""type"": ""Button"",
                    ""id"": ""d89fa843-4e41-4a4f-b46a-f58e298cdd95"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ModeToggle"",
                    ""type"": ""Button"",
                    ""id"": ""4a11aa72-6b2f-4e82-a86b-b3a9452d0b0c"",
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
                    ""id"": ""69ad5e54-07d2-429d-b951-30a4653b3d30"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""d71775f5-c3f1-422f-8e2e-c4941a6d370c"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""e9f09803-ea29-466c-bdf4-f7c66428ac81"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""8956c453-38b4-4e95-bc2b-ba91b966ea0c"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""0b895bae-1557-4014-a55b-7a43dba9c5db"",
                    ""path"": ""<Keyboard>/d"",
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
                },
                {
                    ""name"": """",
                    ""id"": ""238095c8-d3ad-4b97-9ac6-7c7a20545ab4"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""966d0ee7-0cf7-4bd7-b94b-58f9a84f51bd"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""NextAbility"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d7cf33ac-2df9-4e8d-bd47-fd35c0f7e70a"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""NextAbility"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a7f526e8-db1d-4ae2-9882-744a4e26dd9f"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PrevAbility"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5ef2f82d-2b7b-43ca-aa67-c4310d902844"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PrevAbility"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""562c85bb-557c-43a3-987a-19866041309a"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UseAbility"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3869a7cf-1509-41de-bd7a-0715e3f96680"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UseAbility"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0bde4ec5-f5b0-4c32-b1fc-b6ffb6146ac9"",
                    ""path"": ""<Keyboard>/k"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ModeToggle"",
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
        m_TPS_NextAbility = m_TPS.FindAction("NextAbility", throwIfNotFound: true);
        m_TPS_PrevAbility = m_TPS.FindAction("PrevAbility", throwIfNotFound: true);
        m_TPS_UseAbility = m_TPS.FindAction("UseAbility", throwIfNotFound: true);
        m_TPS_ModeToggle = m_TPS.FindAction("ModeToggle", throwIfNotFound: true);
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
    private readonly InputAction m_TPS_NextAbility;
    private readonly InputAction m_TPS_PrevAbility;
    private readonly InputAction m_TPS_UseAbility;
    private readonly InputAction m_TPS_ModeToggle;
    public struct TPSActions
    {
        private @MyCons m_Wrapper;
        public TPSActions(@MyCons wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_TPS_Move;
        public InputAction @Look => m_Wrapper.m_TPS_Look;
        public InputAction @Fire => m_Wrapper.m_TPS_Fire;
        public InputAction @NextAbility => m_Wrapper.m_TPS_NextAbility;
        public InputAction @PrevAbility => m_Wrapper.m_TPS_PrevAbility;
        public InputAction @UseAbility => m_Wrapper.m_TPS_UseAbility;
        public InputAction @ModeToggle => m_Wrapper.m_TPS_ModeToggle;
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
                @NextAbility.started -= m_Wrapper.m_TPSActionsCallbackInterface.OnNextAbility;
                @NextAbility.performed -= m_Wrapper.m_TPSActionsCallbackInterface.OnNextAbility;
                @NextAbility.canceled -= m_Wrapper.m_TPSActionsCallbackInterface.OnNextAbility;
                @PrevAbility.started -= m_Wrapper.m_TPSActionsCallbackInterface.OnPrevAbility;
                @PrevAbility.performed -= m_Wrapper.m_TPSActionsCallbackInterface.OnPrevAbility;
                @PrevAbility.canceled -= m_Wrapper.m_TPSActionsCallbackInterface.OnPrevAbility;
                @UseAbility.started -= m_Wrapper.m_TPSActionsCallbackInterface.OnUseAbility;
                @UseAbility.performed -= m_Wrapper.m_TPSActionsCallbackInterface.OnUseAbility;
                @UseAbility.canceled -= m_Wrapper.m_TPSActionsCallbackInterface.OnUseAbility;
                @ModeToggle.started -= m_Wrapper.m_TPSActionsCallbackInterface.OnModeToggle;
                @ModeToggle.performed -= m_Wrapper.m_TPSActionsCallbackInterface.OnModeToggle;
                @ModeToggle.canceled -= m_Wrapper.m_TPSActionsCallbackInterface.OnModeToggle;
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
                @NextAbility.started += instance.OnNextAbility;
                @NextAbility.performed += instance.OnNextAbility;
                @NextAbility.canceled += instance.OnNextAbility;
                @PrevAbility.started += instance.OnPrevAbility;
                @PrevAbility.performed += instance.OnPrevAbility;
                @PrevAbility.canceled += instance.OnPrevAbility;
                @UseAbility.started += instance.OnUseAbility;
                @UseAbility.performed += instance.OnUseAbility;
                @UseAbility.canceled += instance.OnUseAbility;
                @ModeToggle.started += instance.OnModeToggle;
                @ModeToggle.performed += instance.OnModeToggle;
                @ModeToggle.canceled += instance.OnModeToggle;
            }
        }
    }
    public TPSActions @TPS => new TPSActions(this);
    public interface ITPSActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnFire(InputAction.CallbackContext context);
        void OnNextAbility(InputAction.CallbackContext context);
        void OnPrevAbility(InputAction.CallbackContext context);
        void OnUseAbility(InputAction.CallbackContext context);
        void OnModeToggle(InputAction.CallbackContext context);
    }
}
