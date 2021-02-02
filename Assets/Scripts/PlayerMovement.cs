using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	[SerializeField] private float movementSpeed = 5f;

	public bool started;

	private Player _control;

	private Vector2 _movement;

	/*
	 * enabling the controls for the character movement
	 */
	private void Start()
	{
		_control = new Player();
		_control.Enable();
	}

	/*
	 * The player movement direction shall be get inside the update function
	 * - read the value of the input of the Movement property
	 */
	private void Update()
	{
		if (started)
			_movement = _control.player.Movement.ReadValue<Vector2>();
		
		// TODO add interaction system for the player
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