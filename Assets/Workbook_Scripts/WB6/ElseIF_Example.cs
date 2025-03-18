using Unity.VisualScripting;
using UnityEngine;

public class ElseIF_Example: MonoBehaviour
{
    int playerHealth = 50;
    // A condition is an expression that evaluats to either true or false
    // Here, playerHealth = 50 is the condition
    // Is playerHealth is greater than 50, it evaluates to true
    // Otherwise, it evaluates to false
    void Update()
    {
        if (playerHealth > 75)
        {
            // The code executes if condition 1 is true
            Debug.Log("You are in greate shape!");
        }
        else if (playerHealth > 50)
        {
            // The code exectutes is condition 2 is true
            Debug.Log("You are doing okay, but be careful!");
        }
        else
        {
            // The code executes if none of the conditions are true
            Debug.Log("You need to heal!");
        }
    }
    /* If playerHealth is above 75, "You are in great shape!" is displayed.
     * Otherwise, if playerHealth is betwenn 521-75, "You are doing okay, but be careful!" is displayed.
     * Otherwise, playerHealth is 50 or belore, "You need to heal!" is displayed. 
     */
}
