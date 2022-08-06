// GENERATED AUTOMATICALLY FROM 'Assets/Configs/InputSystem/MainInputAction.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @MainInputAction : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @MainInputAction()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""MainInputAction"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""8e8a8322-33ec-429a-9563-8fef559413b1"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Button"",
                    ""id"": ""caa0f57f-4068-45e9-ac2b-ff1ed6c26f78"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Run"",
                    ""type"": ""Button"",
                    ""id"": ""5db8c592-ae27-4e23-951e-3a1365e8dadf"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Crouch"",
                    ""type"": ""Button"",
                    ""id"": ""2d284deb-86be-4b5c-8081-895ff9a3d3a6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SwitchItem"",
                    ""type"": ""Button"",
                    ""id"": ""bd1d8836-08f3-4aae-8715-86db6a867b16"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Journal"",
                    ""type"": ""Button"",
                    ""id"": ""be5c630a-7981-4a6f-8776-4c06a07222c4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pickup"",
                    ""type"": ""Button"",
                    ""id"": ""745dc8c0-5b81-479d-9f1f-84229475dd6a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DropItem"",
                    ""type"": ""Button"",
                    ""id"": ""b623bf0e-23c3-4aad-9075-2eaba5c3f4f9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PrimaryUse"",
                    ""type"": ""Button"",
                    ""id"": ""366715ee-9853-4205-ba1b-0717ad11a340"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SecondaryUse"",
                    ""type"": ""Button"",
                    ""id"": ""3b9b162c-8a05-43f2-99a4-89153b0b838f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Flashlight"",
                    ""type"": ""Button"",
                    ""id"": ""e21897a4-44a0-4b49-91a7-f37b487a1d09"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""249acc1c-10c6-4c66-b2b3-849e4bd0f983"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""3b06be53-e697-434d-9e63-70904da6fda1"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""f5c9cf6e-ba17-4bcc-af39-8961718c9666"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""0bbd97e4-c73c-4b3d-a538-0144b3711f86"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""1d94d104-ce41-446b-adf9-3b800b5603b7"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""f253064c-0358-4f78-8f7d-53e8f813fcd3"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""46f9eee1-3caa-4d4c-a71f-a2f3aa2dacca"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ee776377-3e93-4816-b358-a57a4dbc7775"",
                    ""path"": ""<Keyboard>/j"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Journal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9ad8f9a5-c092-4108-a161-696ae570d58c"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pickup"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0814902d-78f1-4695-b79d-8de1777b2a32"",
                    ""path"": ""<Keyboard>/g"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DropItem"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c4396a49-c895-4956-8578-1798f2e3dd8d"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PrimaryUse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6bfa3eee-7b51-49d4-9ed4-6e4968764664"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwitchItem"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ae288ec6-51c9-4830-b0b0-f6f48f0c06bd"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SecondaryUse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""131b4612-9e13-4a86-81d5-54c4d6a2cf7a"",
                    ""path"": ""<Keyboard>/t"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Flashlight"",
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
            ""devices"": []
        }
    ]
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Movement = m_Player.FindAction("Movement", throwIfNotFound: true);
        m_Player_Run = m_Player.FindAction("Run", throwIfNotFound: true);
        m_Player_Crouch = m_Player.FindAction("Crouch", throwIfNotFound: true);
        m_Player_SwitchItem = m_Player.FindAction("SwitchItem", throwIfNotFound: true);
        m_Player_Journal = m_Player.FindAction("Journal", throwIfNotFound: true);
        m_Player_Pickup = m_Player.FindAction("Pickup", throwIfNotFound: true);
        m_Player_DropItem = m_Player.FindAction("DropItem", throwIfNotFound: true);
        m_Player_PrimaryUse = m_Player.FindAction("PrimaryUse", throwIfNotFound: true);
        m_Player_SecondaryUse = m_Player.FindAction("SecondaryUse", throwIfNotFound: true);
        m_Player_Flashlight = m_Player.FindAction("Flashlight", throwIfNotFound: true);
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
    private readonly InputAction m_Player_Movement;
    private readonly InputAction m_Player_Run;
    private readonly InputAction m_Player_Crouch;
    private readonly InputAction m_Player_SwitchItem;
    private readonly InputAction m_Player_Journal;
    private readonly InputAction m_Player_Pickup;
    private readonly InputAction m_Player_DropItem;
    private readonly InputAction m_Player_PrimaryUse;
    private readonly InputAction m_Player_SecondaryUse;
    private readonly InputAction m_Player_Flashlight;
    public struct PlayerActions
    {
        private @MainInputAction m_Wrapper;
        public PlayerActions(@MainInputAction wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Player_Movement;
        public InputAction @Run => m_Wrapper.m_Player_Run;
        public InputAction @Crouch => m_Wrapper.m_Player_Crouch;
        public InputAction @SwitchItem => m_Wrapper.m_Player_SwitchItem;
        public InputAction @Journal => m_Wrapper.m_Player_Journal;
        public InputAction @Pickup => m_Wrapper.m_Player_Pickup;
        public InputAction @DropItem => m_Wrapper.m_Player_DropItem;
        public InputAction @PrimaryUse => m_Wrapper.m_Player_PrimaryUse;
        public InputAction @SecondaryUse => m_Wrapper.m_Player_SecondaryUse;
        public InputAction @Flashlight => m_Wrapper.m_Player_Flashlight;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Run.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRun;
                @Run.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRun;
                @Run.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRun;
                @Crouch.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCrouch;
                @Crouch.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCrouch;
                @Crouch.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCrouch;
                @SwitchItem.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSwitchItem;
                @SwitchItem.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSwitchItem;
                @SwitchItem.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSwitchItem;
                @Journal.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJournal;
                @Journal.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJournal;
                @Journal.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJournal;
                @Pickup.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPickup;
                @Pickup.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPickup;
                @Pickup.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPickup;
                @DropItem.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDropItem;
                @DropItem.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDropItem;
                @DropItem.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDropItem;
                @PrimaryUse.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPrimaryUse;
                @PrimaryUse.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPrimaryUse;
                @PrimaryUse.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPrimaryUse;
                @SecondaryUse.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSecondaryUse;
                @SecondaryUse.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSecondaryUse;
                @SecondaryUse.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSecondaryUse;
                @Flashlight.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFlashlight;
                @Flashlight.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFlashlight;
                @Flashlight.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFlashlight;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Run.started += instance.OnRun;
                @Run.performed += instance.OnRun;
                @Run.canceled += instance.OnRun;
                @Crouch.started += instance.OnCrouch;
                @Crouch.performed += instance.OnCrouch;
                @Crouch.canceled += instance.OnCrouch;
                @SwitchItem.started += instance.OnSwitchItem;
                @SwitchItem.performed += instance.OnSwitchItem;
                @SwitchItem.canceled += instance.OnSwitchItem;
                @Journal.started += instance.OnJournal;
                @Journal.performed += instance.OnJournal;
                @Journal.canceled += instance.OnJournal;
                @Pickup.started += instance.OnPickup;
                @Pickup.performed += instance.OnPickup;
                @Pickup.canceled += instance.OnPickup;
                @DropItem.started += instance.OnDropItem;
                @DropItem.performed += instance.OnDropItem;
                @DropItem.canceled += instance.OnDropItem;
                @PrimaryUse.started += instance.OnPrimaryUse;
                @PrimaryUse.performed += instance.OnPrimaryUse;
                @PrimaryUse.canceled += instance.OnPrimaryUse;
                @SecondaryUse.started += instance.OnSecondaryUse;
                @SecondaryUse.performed += instance.OnSecondaryUse;
                @SecondaryUse.canceled += instance.OnSecondaryUse;
                @Flashlight.started += instance.OnFlashlight;
                @Flashlight.performed += instance.OnFlashlight;
                @Flashlight.canceled += instance.OnFlashlight;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    private int m_NewcontrolschemeSchemeIndex = -1;
    public InputControlScheme NewcontrolschemeScheme
    {
        get
        {
            if (m_NewcontrolschemeSchemeIndex == -1) m_NewcontrolschemeSchemeIndex = asset.FindControlSchemeIndex("New control scheme");
            return asset.controlSchemes[m_NewcontrolschemeSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnRun(InputAction.CallbackContext context);
        void OnCrouch(InputAction.CallbackContext context);
        void OnSwitchItem(InputAction.CallbackContext context);
        void OnJournal(InputAction.CallbackContext context);
        void OnPickup(InputAction.CallbackContext context);
        void OnDropItem(InputAction.CallbackContext context);
        void OnPrimaryUse(InputAction.CallbackContext context);
        void OnSecondaryUse(InputAction.CallbackContext context);
        void OnFlashlight(InputAction.CallbackContext context);
    }
}