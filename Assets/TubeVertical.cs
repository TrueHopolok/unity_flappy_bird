using UnityEngine;

public class TubeVertical : MonoBehaviour
{

    [SerializeField] float movementSpeed = 1f;

    [SerializeField] float verticalSpread = 2f;

    float currentDirection;

    void Awake()
    {
        Vector3 newPosition = transform.position;
        newPosition.y = Random.Range(-verticalSpread, verticalSpread);
        transform.position = newPosition;

        currentDirection = Mathf.Sign(Random.Range(0, 2) - 0.5f);
    }


    void FixedUpdate()
    {
        Vector3 newPosition = transform.position;
        newPosition.y = Mathf.Clamp(newPosition.y + movementSpeed * currentDirection * Time.fixedDeltaTime, -verticalSpread, verticalSpread);
        if (newPosition.y <= -verticalSpread || verticalSpread <= newPosition.y)
        {
            currentDirection = -currentDirection;
        }
        transform.position = newPosition;
    }
}
