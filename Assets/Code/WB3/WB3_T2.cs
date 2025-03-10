using UnityEngine;

public class WB3_T2 : MonoBehaviour
{
    /* original code: 
    int a = 10;
    int b = 5;
    int result; = a + b * 2;
    */
    int a = 10;
    int b = 5;
    int result; 
    
    void Start()
    {

        /* original code: 
        result = a + b * 2;
        Debug.Log(result);
        */

        //Task: Modify the original code to use parentheses to change the order of operation. The original code (once fixed) gave a Sum of 20.//
        

        result = (a + b) * 2;
        Debug.Log(result);

        //This new code uses BIMDAS principles to provide a Sum of 30.//
    }

 
}
