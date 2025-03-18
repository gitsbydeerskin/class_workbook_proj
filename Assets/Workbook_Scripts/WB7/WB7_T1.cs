using UnityEngine;

public class WB7_T1 : MonoBehaviour
{
    // Workbook 7 Task 1 = Create a While Loop that prints 1-5 incrementally using a While Loop.
    int i = 0;
    void Start()
    {
        while (i < 6)
        {
            // Swapped the position of the + i in order to have the String come afterwards. Originally, it was Debug.Log("Ah, Ah, Ah! " + i);
            // By reversing the + and i variable, I can print the text like the Count from Sesame Street counting! More fun :)
            Debug.Log(i + ", Ah, Ah, Ah!");
            i++;
        }
    }
    
}
