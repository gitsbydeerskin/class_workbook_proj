using System;
using UnityEngine;

public class WB5_Task3_ConvertClass : MonoBehaviour
{
    string numberString = "250";
    int number;
    void Start()
    {
        number = Convert.ToInt32 (numberString);
        Debug.Log (number);
    }

   
}
