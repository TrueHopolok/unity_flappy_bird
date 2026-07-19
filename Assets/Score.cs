using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    TMP_Text text;
    int score = 0;

    void Awake()
    {
        text = GetComponent<TMP_Text>();
        if (!text)
        {
            Debug.LogError("Text not found");
            return;
        }
        text.text = "Score: 0";
    }

    public void Increment()
    {
        score++;
        text.text = $"Score: {score}";
    }
}
