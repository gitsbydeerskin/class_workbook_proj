using UnityEngine;

public class WB9_T2 : MonoBehaviour
{
    // Variables go here
    void Start()
    {
        // Call function here
        Debug.Log(MultiplyNumbers(5, 3));
      
    }
    // Create function here 
    int MultiplyNumbers(int a, int b) 
    { 
       return a * b;
    }
    
}
