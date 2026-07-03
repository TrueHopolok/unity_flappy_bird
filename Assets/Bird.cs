using UnityEngine;
using UnityEngine.InputSystem;

public class Bird : MonoBehaviour
{
    [SerializeField] float jumpForce = 100.0f;
    Rigidbody2D rigidBody;
    InputAction jumpAction;
    bool hasJumped = false;

    void Init()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        jumpAction = InputSystem.actions.FindAction("Jump");
    }

    void FixedUpdate()
    {
        // bool hasPressedSpace = Input.GetKeyDown(KeyCode.Space);
        bool hasPressedSpace = jumpAction.IsPressed();
        if (!hasJumped && hasPressedSpace)
        {
            rigidBody.linearVelocityY = jumpForce;
        }
        hasJumped = hasPressedSpace;
    }
}
