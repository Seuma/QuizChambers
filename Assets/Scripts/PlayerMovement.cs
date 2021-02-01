using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 5f;

    private Vector2 _movement;

    private Player _control;
    // Start is called before the first frame update
    void Start()
    {
        _control = new Player();
        _control.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        _movement = _control.player.Movement.ReadValue<Vector2>();
    }

    private void FixedUpdate()
    {
        transform.position += new Vector3(_movement.x, _movement.y) * (Time.deltaTime * movementSpeed);
    }
}
