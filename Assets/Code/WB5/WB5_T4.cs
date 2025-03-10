using UnityEngine;

public class WB5_T4 : MonoBehaviour
{
    // Workbook 5 Task 4 = Take user input from the Inspector Window and convert it into a float using float.Parse(), then print the result.
    public string numberString = "123";
    float number;
    void Start()
    {
        number = float.Parse(numberString);  
        Debug.Log(number);
    }

   
}
