using UnityEngine;

public class WB3_T5 : MonoBehaviour
{
    // Task: swap the values without a temp variable using arithmetic.
    int a = 5;
    int b = 10;
    void Start()
    {
        /* 
           I learned about a few different ways to do this while figuring this out.
           Apparently, multiplication + division would be better for int overflow. But I don't understand Int oferflow or why I should be concerned about it, so I decided to stick with this method.
           This is also something called XOR, which works for all Int values and has no risk of Overflow. But we haven't covered it yet, so I'm not touching it.
           My partner also found out about something called "tuples" when I was rubber duckying off him, which was added in C#7. It was added explicitly as a way to swap two Variables without the need of a Temp variable. 
           Tuples sounds like the perfect use-case for this scenario, but as we haven't covered it, I decided not to look into it futher at this point.
        */

        a = a + b;
        b = a - b;
        a = a - b;
        // This prints the new swapped values where a=10, b=5.
        Debug.Log("a: " + a);
        Debug.Log("b: " + b);


        // Below is my original solution. I used an Assignment Operator instead of an Arithematic Operatpor. This meant I was simply reassinging the values instead of swapping them.

        /*
        a = 10;
        b = 5;
        Debug.Log("a: " + a);
        Debug.Log("b: " + b);
        */
    }


}
