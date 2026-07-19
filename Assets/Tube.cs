using UnityEngine;

public class Tube : MonoBehaviour
{
    [SerializeField] float movementSpeed = 4f;
    [SerializeField] float outOfBounds = -20f;

    void FixedUpdate()
    {
        transform.position = transform.position + new Vector3(-movementSpeed * Time.fixedDeltaTime, 0, 0);
        if (transform.position.x < outOfBounds)
        {
            Destroy(gameObject); // destroy itself
        }
    }
}
