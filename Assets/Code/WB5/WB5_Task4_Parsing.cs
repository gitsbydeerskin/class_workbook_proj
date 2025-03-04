using UnityEngine;

public class WWB5_Task4_Parsing : MonoBehaviour
{
    public string numberString = "123";
    int number;
    void Start()
    {
        number = int.Parse(numberString);  
        Debug.Log(number);
    }

   
}
