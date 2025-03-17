using UnityEngine;

public class WB6_T3 : MonoBehaviour
{
    /* If-Else IF Grading System: 
    • If exam score is 90 or more, print "You got an A!".
    • If exam score is 75 or more, print "You got a B!".
    • Otherwise, print "You need to study harder!".*/
   [SerializeField] int grades = 80;
    void Start()
    {
        if (grades > 90)
        {
            // If the Grade is above 90, the Console prints the below response
            Debug.Log("Amazing! You got an A!");
        }
        else if (grades > 75)
        {
            // If the Grade is above 75, the Console prints the below response
            Debug.Log("You got a B! Keep up the good work!");
        }
        else if (grades > 50)
            // If the Grade is above 50, the below response is printed
        {
            Debug.Log("You can do better than that. I believe in you!");
        }
        // I was curious how many if statements you could do - if you could do more than the 3 the examples showed. This is me trying that: 
        else
        {
            // It works! If you have a woefully LOW score <50, this is printed to the Console!
            Debug.Log("Omg. Are you even trying?");
        }
    }

}
