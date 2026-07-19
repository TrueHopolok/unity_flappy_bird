using UnityEngine;

public class WinTrigger : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            GameObject obj = GameObject.Find("Score"); // slow, but sometimes useful
            if (!obj)
            {
                Debug.LogError("Score not found");
                return;
            }
            if (obj.TryGetComponent<Score>(out Score text))
            {
                text.Increment();
            }
        }
    }
}
