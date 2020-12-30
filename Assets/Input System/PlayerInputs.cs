// GENERATED AUTOMATICALLY FROM 'Assets/Input System/PlayerInputs.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInputs : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputs()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputs"",
    ""maps"": [
        {
            ""name"": ""Player1"",
            ""id"": ""199788dc-4095-47e1-9d4a-b2dd5b411537"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""579e7638-bfad-4207-91e2-69fc68820db9"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Set Bomb"",
                    ""type"": ""Button"",
                    ""id"": ""5f453246-8dc1-49a7-894c-7e84864e201b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""d86e81a5-aeeb-4bd4-bd78-08a4fc10571f"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Set Bomb"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WAD"",
                    ""id"": ""df8d6e2d-688f-46f8-a1ef-00c93a58cd82"",
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
                    ""id"": ""fc8237f2-be24-463c-8630-4261ee50ba94"",
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
                    ""id"": ""2327c29c-2c81-40b4-a5b6-578dd8b9ce01"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""6da5ac03-a892-484c-a286-9fe8f292f9b4"",
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
                    ""id"": ""9f613e95-f493-4765-ac33-2ac361997b63"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Player2"",
            ""id"": ""141fbb0c-417e-45a9-8f1d-c56c6677767b"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""992e445e-6cc4-49c1-aa20-f087d9eecb9f"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SetBomb"",
                    ""type"": ""Button"",
                    ""id"": ""25af9587-5a4f-4707-8049-f9eb4ee68da2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""758b9348-a028-42db-8dd6-ecdfe2601652"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SetBomb"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Arrow"",
                    ""id"": ""93e67d7e-17ef-49d4-be30-5188ba22ad5d"",
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
                    ""id"": ""1fe3fd1d-eef4-4a42-8601-385a096e5033"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""d47e9a62-02cd-4cc6-b72e-0472357763b6"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""31e24038-3f7f-4cd4-867e-ac2455d7bbc0"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""ec317607-e0f3-4aa2-b38f-962a1c664c63"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""PlayerM"",
            ""id"": ""5a0a6f0b-2a2d-4bb5-8769-cc2d91203d90"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""8ae4a124-f370-4b6a-853c-ddc36eef23f5"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SetBomb"",
                    ""type"": ""Button"",
                    ""id"": ""65e3fc25-ce7c-4eef-b273-d27d57970d4f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WAD"",
                    ""id"": ""9832f7a0-6ddd-4d0c-9927-6152150d0d70"",
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
                    ""id"": ""e1a681ce-7f52-473a-9d49-69a1ff7fe6b6"",
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
                    ""id"": ""c9d50668-469b-4706-a23f-1119f57357f6"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""6201ffad-d6fa-4d37-b703-b49e10d1fc28"",
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
                    ""id"": ""ebc94303-9141-47b6-9e85-07a999e2d197"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrows"",
                    ""id"": ""f61db641-be6d-40f0-a6b1-a9c38261f20c"",
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
                    ""id"": ""95a4456f-32ad-411a-b9ef-a78ce74e626c"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""2c923f66-6fff-498f-9d21-c30b8e3093cb"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""e623f9b2-482f-4546-acea-4038ac50cb03"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""bf5fceb3-7224-4459-8200-5e78db2a5784"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""18f73dc6-0cb8-4c73-acc5-73a825bb6f6a"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SetBomb"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""23320cfe-71a3-41b5-9628-3da1d7ae4279"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SetBomb"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player1
        m_Player1 = asset.FindActionMap("Player1", throwIfNotFound: true);
        m_Player1_Move = m_Player1.FindAction("Move", throwIfNotFound: true);
        m_Player1_SetBomb = m_Player1.FindAction("Set Bomb", throwIfNotFound: true);
        // Player2
        m_Player2 = asset.FindActionMap("Player2", throwIfNotFound: true);
        m_Player2_Move = m_Player2.FindAction("Move", throwIfNotFound: true);
        m_Player2_SetBomb = m_Player2.FindAction("SetBomb", throwIfNotFound: true);
        // PlayerM
        m_PlayerM = asset.FindActionMap("PlayerM", throwIfNotFound: true);
        m_PlayerM_Move = m_PlayerM.FindAction("Move", throwIfNotFound: true);
        m_PlayerM_SetBomb = m_PlayerM.FindAction("SetBomb", throwIfNotFound: true);
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

    // Player1
    private readonly InputActionMap m_Player1;
    private IPlayer1Actions m_Player1ActionsCallbackInterface;
    private readonly InputAction m_Player1_Move;
    private readonly InputAction m_Player1_SetBomb;
    public struct Player1Actions
    {
        private @PlayerInputs m_Wrapper;
        public Player1Actions(@PlayerInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Player1_Move;
        public InputAction @SetBomb => m_Wrapper.m_Player1_SetBomb;
        public InputActionMap Get() { return m_Wrapper.m_Player1; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Player1Actions set) { return set.Get(); }
        public void SetCallbacks(IPlayer1Actions instance)
        {
            if (m_Wrapper.m_Player1ActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnMove;
                @SetBomb.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnSetBomb;
                @SetBomb.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnSetBomb;
                @SetBomb.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnSetBomb;
            }
            m_Wrapper.m_Player1ActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @SetBomb.started += instance.OnSetBomb;
                @SetBomb.performed += instance.OnSetBomb;
                @SetBomb.canceled += instance.OnSetBomb;
            }
        }
    }
    public Player1Actions @Player1 => new Player1Actions(this);

    // Player2
    private readonly InputActionMap m_Player2;
    private IPlayer2Actions m_Player2ActionsCallbackInterface;
    private readonly InputAction m_Player2_Move;
    private readonly InputAction m_Player2_SetBomb;
    public struct Player2Actions
    {
        private @PlayerInputs m_Wrapper;
        public Player2Actions(@PlayerInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Player2_Move;
        public InputAction @SetBomb => m_Wrapper.m_Player2_SetBomb;
        public InputActionMap Get() { return m_Wrapper.m_Player2; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Player2Actions set) { return set.Get(); }
        public void SetCallbacks(IPlayer2Actions instance)
        {
            if (m_Wrapper.m_Player2ActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnMove;
                @SetBomb.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnSetBomb;
                @SetBomb.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnSetBomb;
                @SetBomb.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnSetBomb;
            }
            m_Wrapper.m_Player2ActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @SetBomb.started += instance.OnSetBomb;
                @SetBomb.performed += instance.OnSetBomb;
                @SetBomb.canceled += instance.OnSetBomb;
            }
        }
    }
    public Player2Actions @Player2 => new Player2Actions(this);

    // PlayerM
    private readonly InputActionMap m_PlayerM;
    private IPlayerMActions m_PlayerMActionsCallbackInterface;
    private readonly InputAction m_PlayerM_Move;
    private readonly InputAction m_PlayerM_SetBomb;
    public struct PlayerMActions
    {
        private @PlayerInputs m_Wrapper;
        public PlayerMActions(@PlayerInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_PlayerM_Move;
        public InputAction @SetBomb => m_Wrapper.m_PlayerM_SetBomb;
        public InputActionMap Get() { return m_Wrapper.m_PlayerM; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerMActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerMActions instance)
        {
            if (m_Wrapper.m_PlayerMActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_PlayerMActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerMActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerMActionsCallbackInterface.OnMove;
                @SetBomb.started -= m_Wrapper.m_PlayerMActionsCallbackInterface.OnSetBomb;
                @SetBomb.performed -= m_Wrapper.m_PlayerMActionsCallbackInterface.OnSetBomb;
                @SetBomb.canceled -= m_Wrapper.m_PlayerMActionsCallbackInterface.OnSetBomb;
            }
            m_Wrapper.m_PlayerMActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @SetBomb.started += instance.OnSetBomb;
                @SetBomb.performed += instance.OnSetBomb;
                @SetBomb.canceled += instance.OnSetBomb;
            }
        }
    }
    public PlayerMActions @PlayerM => new PlayerMActions(this);
    public interface IPlayer1Actions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnSetBomb(InputAction.CallbackContext context);
    }
    public interface IPlayer2Actions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnSetBomb(InputAction.CallbackContext context);
    }
    public interface IPlayerMActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnSetBomb(InputAction.CallbackContext context);
    }
}
