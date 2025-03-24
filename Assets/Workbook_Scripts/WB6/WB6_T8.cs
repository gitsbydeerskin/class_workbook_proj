using UnityEngine;
/* Task: Enemy AI using if-else Statements
 Create a C# script called EnemyAI.
Declare an integer variable player distance and set it to 15.
Write an if-else if-else structure to print:
• If player distance < 5, print "The enemy attacks!".
• If player distance < 15, print "The enemy is watching you...".
• Otherwise, print "The enemy ignores you.".
 */
public class WB6_T8 : MonoBehaviour
{
    [SerializeField] int playerDistance = 4;
    void Start()
    {
        if (playerDistance < 5)
        {
            Debug.Log("You're too close! The enemy gets a hit in!");
        }
        else if (playerDistance > 5 && playerDistance < 15)
        {
            Debug.Log("The enemy is watching you...");
        }
        else
        {
            Debug.Log("The enemy ignores you.");
        }
    
    }


}
