using UnityEngine;
using UnityEngine.InputSystem;

public class Bird : MonoBehaviour
{
    [SerializeField] float jumpForce = 1.0f;
    Rigidbody2D rigidBody;
    InputControlls controls;
    InputAction jumpAction;
    bool hasJumped = false;

    void Awake()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        controls = new InputControlls();
        controls.Enable();
        jumpAction = controls.Player.Jump;
    }

    void FixedUpdate()
    {
        // bool hasPressedSpace = Input.GetKeyDown(KeyCode.Space);
        bool hasPressedSpace = jumpAction.IsPressed();
        Debug.Log(hasPressedSpace);
        if (!hasJumped && hasPressedSpace)
        {
            rigidBody.linearVelocityY = jumpForce;
        }
        hasJumped = hasPressedSpace;
    }

    void OnDestroy()
    {
        controls.Disable();
        controls.Dispose();       
    }
}
