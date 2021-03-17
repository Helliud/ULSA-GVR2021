// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/VRControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @VRControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @VRControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""VRControls"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""d2970db1-40d4-469f-9a57-856e791880d7"",
            ""actions"": [
                {
                    ""name"": ""VRClick"",
                    ""type"": ""Button"",
                    ""id"": ""eb7cb811-fe26-42bb-95b6-7c033dc8f036"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""903ffb9c-c8c3-4eb1-ac51-ae4814d7a476"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""VRClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a217f1cb-310f-41fd-ae6a-eec18c33c8a4"",
                    ""path"": ""<Touchscreen>/primaryTouch/tap"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Android"",
                    ""action"": ""VRClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Android"",
            ""bindingGroup"": ""Android"",
            ""devices"": []
        },
        {
            ""name"": ""PC"",
            ""bindingGroup"": ""PC"",
            ""devices"": []
        }
    ]
}");
        // Gameplay
        m_Gameplay = asset.FindActionMap("Gameplay", throwIfNotFound: true);
        m_Gameplay_VRClick = m_Gameplay.FindAction("VRClick", throwIfNotFound: true);
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

    // Gameplay
    private readonly InputActionMap m_Gameplay;
    private IGameplayActions m_GameplayActionsCallbackInterface;
    private readonly InputAction m_Gameplay_VRClick;
    public struct GameplayActions
    {
        private @VRControls m_Wrapper;
        public GameplayActions(@VRControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @VRClick => m_Wrapper.m_Gameplay_VRClick;
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterface != null)
            {
                @VRClick.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnVRClick;
                @VRClick.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnVRClick;
                @VRClick.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnVRClick;
            }
            m_Wrapper.m_GameplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @VRClick.started += instance.OnVRClick;
                @VRClick.performed += instance.OnVRClick;
                @VRClick.canceled += instance.OnVRClick;
            }
        }
    }
    public GameplayActions @Gameplay => new GameplayActions(this);
    private int m_AndroidSchemeIndex = -1;
    public InputControlScheme AndroidScheme
    {
        get
        {
            if (m_AndroidSchemeIndex == -1) m_AndroidSchemeIndex = asset.FindControlSchemeIndex("Android");
            return asset.controlSchemes[m_AndroidSchemeIndex];
        }
    }
    private int m_PCSchemeIndex = -1;
    public InputControlScheme PCScheme
    {
        get
        {
            if (m_PCSchemeIndex == -1) m_PCSchemeIndex = asset.FindControlSchemeIndex("PC");
            return asset.controlSchemes[m_PCSchemeIndex];
        }
    }
    public interface IGameplayActions
    {
        void OnVRClick(InputAction.CallbackContext context);
    }
}
