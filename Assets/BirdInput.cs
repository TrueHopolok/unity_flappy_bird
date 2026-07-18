using UnityEngine;
using UnityEngine.InputSystem;

public class BirdInput : MonoBehaviour
{
    // Works best with gravity scale being x2
    [SerializeField] float jumpVelocity = 8.0f;
    Rigidbody2D rigidBody;
    InputControls controls;
    InputAction jumpAction;
    bool jumpRequested = false;

    void Awake()
    {
        // Connecting all components
        rigidBody = GetComponent<Rigidbody2D>();

        // Initializing controls for this GameObject
        controls = new InputControls();
        controls.Enable();

        // Assigning all input actions
        jumpAction = controls.Player.Jump;
    }

    // Everything is handled here including input,
    // with sole exception of physics of course
    void Update()
    {
        if (jumpAction.WasPressedThisFrame())
        {
            jumpRequested = true;
        }
    }

    // Handles physics logic
    void FixedUpdate()
    {
        if (jumpRequested)
        {
            rigidBody.linearVelocityY = jumpVelocity;
            jumpRequested = false;
        }
    }

    void OnEnable()
    {
        controls.Enable();
    }

    void OnDisable()
    {
        controls.Disable();
    }

    // Destructor of the GameObject
    void OnDestroy()
    {
        // Frees memory
        controls.Dispose();
    }
}