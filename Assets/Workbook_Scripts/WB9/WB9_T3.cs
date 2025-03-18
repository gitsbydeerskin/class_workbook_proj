using UnityEngine;

public class WB9_T3 : MonoBehaviour
{
    /* WB9 Task 3 = Return Type: bool - Is Even Number 
       Create a function named IsEvenNumber() that takes an integer parameter and returns
       true if the number is even and false if the number is odd.*/

    // Variables here
    public int number = 8;
    void Start()
    {
        // Function Call here
        GetOddNumber(number);
    }
    // Function creation here
    bool GetOddNumber(int numberToCheck)
    {
        if (numberToCheck % 2 == 0)
        {
            Debug.Log($"{numberToCheck} is even! ");
            return true;

        }
        else
        {
            Debug.Log($"{numberToCheck} Unlucky! this is odd");
            return false;

        }

        // An alternative way of doing the above would be: 
        /* 
            bool IsEvenNumber(int valueToCheck)
            {
                return (valueToCheck % 2 == 0)
            }
        */

    }

}
