using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputManager : MonoBehaviour
{
    public InputActionAsset input;
    public int speed;
    private bool isMovementDebugging = false;
    private InputAction move;
    private InputAction moveForward;
    private InputAction turn;

    private Rigidbody rb;

    private void OnEnable()
    {
        move = input.FindAction("Move");
        moveForward = input.FindAction("MoveForward");
        turn = input.FindAction("Turn");
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (moveForward.IsPressed())
        {
            rb.linearVelocity = transform.rotation.eulerAngles * speed;
        }
        if (move.IsPressed() && isMovementDebugging)
        {
            Vector2 direction = move.ReadValue<Vector2>();
            direction *= speed;
            rb.linearVelocity = new Vector3(direction.x, rb.linearVelocity.y, direction.y);
        } else
        {
            rb.linearVelocity = new Vector3(0, rb.linearVelocity.y, 0);
        }
    }
}
