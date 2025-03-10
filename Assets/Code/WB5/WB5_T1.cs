using UnityEngine;

public class WB5_T1 : MonoBehaviour
{
    // Task = use Implicit Casting to convert an int into a float variable.
    int number = 69;
    float floatNumber;

    void Start()
    {
        floatNumber = number;
        // This uses String Interpolation to print both values in the same line.
        Debug.Log($"The int value is: {number}. The float value is: {floatNumber}");
    }


}
