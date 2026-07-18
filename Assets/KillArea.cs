using UnityEngine;

public class KillArea : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Hello");
    }
}
