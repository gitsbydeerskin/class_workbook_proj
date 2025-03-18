using UnityEngine;

public class WB3_T1 : MonoBehaviour
{
    int a = 4;
    int b = 3;
    int additionSum;
    int subtractionSum;
    int multiplicationSum;
    int divisionSum;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        additionSum = a + b;
        Debug.Log(additionSum);
        
        subtractionSum = a - b;
        Debug.Log(subtractionSum);
       
        multiplicationSum = a * b;
        Debug.Log(multiplicationSum);
        
        divisionSum = a / b;
        Debug.Log(divisionSum);
        

    }


}
