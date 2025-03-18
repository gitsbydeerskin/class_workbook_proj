using UnityEngine;

public class WB4_T2: MonoBehaviour
{
    // Workbook 4 Task 2: Concatenate a name with hello to display a greeting.
    string firstName = "Dave";
    string greeting = "Hello,";
    string sentence;
    void Start()
    {
        sentence = greeting + " " + firstName;
        Debug.Log(sentence);
    }

}