using UnityEngine;

public class KillArea : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        GameObject obj = other.gameObject;
        Debug.Log("Trigger entered by: " + obj.name);

        if (other.CompareTag("Player"))
        {
            Debug.Log("This object was a player");
            if (obj.TryGetComponent<BirdDeath>(out BirdDeath animator))
            {
                animator.Die();
            }
        }
    }
}