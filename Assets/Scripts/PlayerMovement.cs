using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	[SerializeField] private float movementSpeed = 5f;

	[SerializeField] private GameManager gameManager;

	private InteractionManager _interactionManager;
	
	public bool started;

	private Player _control;

	private Vector2 _movement;

	/*
	 * enabling the controls for the character movement
	 */
	private void Start()
	{
		gameManager.InDialog = false;
		_interactionManager = GetComponent<InteractionManager>();
		_control = new Player();
		_control.Enable();
	}

	/*
	 * The player movement direction shall be get inside the update function
	 * - read the value of the input of the Movement property
	 * - trigger interacting with objects
	 */
	private void Update()
	{
		if (!started) return;
		
		if (!gameManager.InDialog)
			_movement = _control.player.Movement.ReadValue<Vector2>();
			
		if (_control.player.Interact.triggered)
		{
			_movement = new Vector2(0, 0);
			_interactionManager.Interact();
		}
	}

	/*
	 * in the fixed update the movement shall happen
	 * it shall happen here to prevent collision issues while moving
	 */
	private void FixedUpdate()
	{
		if (started)
			transform.position += new Vector3(_movement.x, _movement.y) * (Time.deltaTime * movementSpeed);
	}
}