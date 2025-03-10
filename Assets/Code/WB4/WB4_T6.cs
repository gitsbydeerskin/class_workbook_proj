using UnityEngine;

public class WB4_T6 : MonoBehaviour
{
    // Workbook 4 Task 6: Temperature Display using String Formatting.
    string tempOne = "The current temperature is";
    float temp = 24.0f;
    string tempTwo = "c.";
    string formattedString;

    void Start()
    {
        formattedString = string.Format("{0} {1}{2}", tempOne, temp, tempTwo);
        Debug.Log(formattedString);
    }

  
}
