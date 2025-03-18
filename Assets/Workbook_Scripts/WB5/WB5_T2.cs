using UnityEngine;

public class WB5_T2: MonoBehaviour
{
    // Workbook 5 Task 2 = convert a float into an int and print both values using Debug.Log
    float floatNumber = 6.9696969f;
    int number;
    void Start()
    {
        number = (int)floatNumber;
    
        Debug.Log($"{number} : {floatNumber}"); 
    }

}
