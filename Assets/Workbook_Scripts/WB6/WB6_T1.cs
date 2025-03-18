using UnityEngine;

public class WB6_T1 : MonoBehaviour
{
    // Task = Statement checks if the score is greater than 50, then prints "Great job! You passed!"
    [SerializeField] int score = 40;
    void Start()
    {
        if (score >= 50)
        {
            Debug.Log("Great job! You win!");
        }
    }
    // Changing the score from 50 to 40 means nothing is displayed in the console, as there is no else condition
}
