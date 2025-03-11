using UnityEngine;
using UnityEngine.UIElements;

public class ClassSlideLoop : MonoBehaviour
{
    // While Loop: 
    int w = 0;

    // Do While Loop: 
    int d = 0;

    //For Each Loop:
    string[] fruits = { "Apple", "Banana", "Cherry" };
    void Start()
    {
        // While Loop: 
        while (w < 5)
        {
            Debug.Log("This is While loop number " + w);
            w++;
        }

        // Do While Loop: 
        do
        {
            Debug.Log("This is Do While loop number " + d);
            d++;
        }
        // Do While Loop Cont.: Changing this from < 5 to < -1 makes the Do While only able to run once instead of 5 times.
        while (d < -1);

        // For Loop
        for (int i = 0; i < 5; i++)
        {
            Debug.Log("This is For loop number " + i);
        }

        // For Each Loop Cont.:
        foreach (string fruit in fruits)
        {
            Debug.Log(fruit);
        }

    }

}
