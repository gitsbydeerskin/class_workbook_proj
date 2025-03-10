using System;
using UnityEngine;

public class WB5_T3 : MonoBehaviour
{
    // Workbook 5 Task 3 = Convert the string 250 into an int using Convert.ToInt32() and print the results.
    string numberString = "250";
    int number;
    void Start()
    {
        number = Convert.ToInt32(numberString);
        Debug.Log(number);
    }

    /* Originally when I tried to do this I was getting errors saying 'Convert' does not exist in the current context.
       After looking up the error online, I found out that Convert exists in the "System" namespace so you have to import the namespace.
       https://discussions.unity.com/t/the-name-convert-does-not-exist-in-the-current-context-c/134443/3
    */
}
