using UnityEngine;

public class WB4_T9 : MonoBehaviour
{
    // Workbook 4 Task 9 = Combine numbers and strings with a simple math operation using an Ineterpolated String.
    int a = 5;
    int b = 10;
    int sum;
    string formatSum;
    void Start()
    {
        sum = a + b;
        formatSum = $"The sum of {a} and {b} is {sum}.";
        Debug.Log(formatSum);
    }

 
}
