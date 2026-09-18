using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputManager : MonoBehaviour
{
    public InputActionAsset input;
    public int speed;
    public int turnSpeed;
    public PlayerManager manager;
    private bool isMovementDebugging;
    private InputAction move;
    private InputAction moveForward;
    private InputAction turn;

    private Rigidbody rb;

    private void OnEnable()
    {
        isMovementDebugging = manager.isMovementDebugging;
        move = input.FindAction("Move");
        moveForward = input.FindAction("MoveForward");
        turn = input.FindAction("Turn");
        rb = GetComponent<Rigidbody>();
        rb.maxLinearVelocity = 5;
    }

    private void Update()
    {
        if (moveForward.IsPressed() && !isMovementDebugging)
        {
            Vector2 direction = move.ReadValue<Vector2>() * speed;
            rb.AddRelativeForce(new Vector3(direction.x, rb.linearVelocity.y, direction.y));
        }
        if (move.IsPressed() && isMovementDebugging)
        {
            Vector2 direction = move.ReadValue<Vector2>() * speed;
            rb.linearVelocity = new Vector3(direction.x, rb.linearVelocity.y, direction.y);
        } else
        {
            rb.linearVelocity = new Vector3(0, rb.linearVelocity.y, 0);
        }
        if (turn.IsPressed() && moveForward.IsPressed())
        {
            float direction = turn.ReadValue<float>();
            gameObject.transform.Rotate(0, (direction * gameObject.transform.rotation.y) + (turnSpeed * direction), 0);
        }
    }
}
