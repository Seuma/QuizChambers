// GENERATED AUTOMATICALLY FROM 'Assets/Input/Player.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;
using Object = UnityEngine.Object;

public class Player : IInputActionCollection, IDisposable
{
	// player
	private readonly InputActionMap m_player;
	private readonly InputAction m_player_Interact;
	private readonly InputAction m_player_Movement;
	private IPlayerActions m_PlayerActionsCallbackInterface;

	public Player()
	{
		asset = InputActionAsset.FromJson(@"{
    ""name"": ""Player"",
    ""maps"": [
        {
            ""name"": ""player"",
            ""id"": ""7f4c00a7-5cb4-414c-b323-13c996e7b8e9"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Button"",
                    ""id"": ""934dfcfc-eee4-45dc-aa8d-ad8617ebdb1b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""a1f73b96-dfc2-46fa-b93c-f18c08742964"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""PC"",
                    ""id"": ""16368ddc-7737-4c66-a222-6e770a8f7cf4"",
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
                    ""id"": ""221368c1-8ea3-4cda-8923-f46332bf6347"",
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
                    ""id"": ""15cbe6e0-4d7d-4f2c-af5d-c5bbbd1cf652"",
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
                    ""id"": ""314b807b-aaa8-4eb3-8dd8-27f926123227"",
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
                    ""id"": ""945ce944-de09-4a47-8a4c-6305dd69ca3b"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""PC_Arrow"",
                    ""id"": ""7ee68c60-c2b7-4978-adec-4f02e18f92a7"",
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
                    ""id"": ""060e8300-adcd-410b-90a3-2dfc193e2167"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""1234016a-f701-4c42-96d6-b42af1026b8b"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""d7acb293-1274-4963-b875-58f5d31d6c61"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""086a4689-8026-4ea4-ad4f-af1698cdd3ab"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""31d43b58-fb08-4a6c-b992-b0e37aae9d77"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
		// player
		m_player = asset.FindActionMap("player", true);
		m_player_Movement = m_player.FindAction("Movement", true);
		m_player_Interact = m_player.FindAction("Interact", true);
	}

	public InputActionAsset asset { get; }
	public PlayerActions player => new PlayerActions(this);

	public void Dispose()
	{
		Object.Destroy(asset);
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

	public struct PlayerActions
	{
		private readonly Player m_Wrapper;

		public PlayerActions(Player wrapper)
		{
			m_Wrapper = wrapper;
		}

		public InputAction Movement => m_Wrapper.m_player_Movement;
		public InputAction Interact => m_Wrapper.m_player_Interact;

		public InputActionMap Get()
		{
			return m_Wrapper.m_player;
		}

		public void Enable()
		{
			Get().Enable();
		}

		public void Disable()
		{
			Get().Disable();
		}

		public bool enabled => Get().enabled;

		public static implicit operator InputActionMap(PlayerActions set)
		{
			return set.Get();
		}

		public void SetCallbacks(IPlayerActions instance)
		{
			if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
			{
				Movement.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
				Movement.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
				Movement.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
				Interact.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteract;
				Interact.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteract;
				Interact.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteract;
			}

			m_Wrapper.m_PlayerActionsCallbackInterface = instance;
			if (instance != null)
			{
				Movement.started += instance.OnMovement;
				Movement.performed += instance.OnMovement;
				Movement.canceled += instance.OnMovement;
				Interact.started += instance.OnInteract;
				Interact.performed += instance.OnInteract;
				Interact.canceled += instance.OnInteract;
			}
		}
	}

	public interface IPlayerActions
	{
		void OnMovement(InputAction.CallbackContext context);
		void OnInteract(InputAction.CallbackContext context);
	}
}