using UnityEngine;

public class WB3_T3 : MonoBehaviour
{
    // Task: change the value of x & y to see how the Modulus Operator works. The original values were x = 10, y = 2 // 
    int x = 10;
    int y = 2;
    
    void Start()
    {
        Debug.Log(x % y); //Modulus (remainder), as in, how many is LEFT after the division. 10 divided by 2 = 0 LEFT OVER
    }

  
}
