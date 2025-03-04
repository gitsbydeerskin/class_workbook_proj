using UnityEngine;

public class WB5_CH2 : MonoBehaviour
{
    float floatNumber = 6.9696969f;
    int number;
    void Start()
    {
        number = (int)floatNumber;
    
        Debug.Log($"{number} : {floatNumber}"); 
    }

}
