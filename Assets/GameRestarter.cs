using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class GameRestarter : MonoBehaviour
{
    InputControls controls;
    InputAction restartAction;

    void Awake()
    {
        // Initializing controls for this GameObject
        controls = new InputControls();
        controls.Enable();

        // Assigning all input actions
        restartAction = controls.Global.Restart;
    }

    void OnEnable()
    {
        controls.Enable();
    }

    void OnDisable()
    {
        controls.Disable();
    }

    void OnDestroy()
    {
        controls.Dispose();
    }

    void Update()
    {
        if (restartAction.WasPressedThisFrame())
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
