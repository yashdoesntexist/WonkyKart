using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputManager : MonoBehaviour
{
    public InputActionAsset input;
    public int speed;
    private InputAction move;

    private Rigidbody rb;

    private void OnEnable()
    {
        move = input.FindAction("Move");
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (move.IsPressed())
        {
            Vector2 direction = move.ReadValue<Vector2>();
            rb.linearVelocity = new Vector3(direction.x, rb.linearVelocity.y, direction.y) * speed;
        } else
        {
            rb.linearVelocity = Vector3.zero;
        }
    }
}
