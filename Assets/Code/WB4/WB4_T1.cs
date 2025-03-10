using UnityEngine;

public class WB4_T1 : MonoBehaviour
{
    // Workbook 4 Task 1: Use Arithmetic operations to concatenate two string variables into one printed message in the Debug Log.
    string firstName = "Dave";
    string response = "I can't let you do that";
    string sentence;

    void Start()
    {
        sentence = response + " " + firstName;
        Debug.Log(sentence);
    }

}


