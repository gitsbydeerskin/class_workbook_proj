using UnityEngine;
/* Task: Comparing Two Values
   Declare two integer variables.
  • One for player speed set to 10
  • One for enemy speed set to 12
  Write an if statement that checks if the player is faster than the enemy.
  If true, print "You outrun the enemy!".
  Otherwise, print "The enemy is faster! Be careful!" */
public class WB6_T4 : MonoBehaviour
{
   [SerializeField] int playerSpeed = 10;
    [SerializeField] int enemySpeed = 12;
    void Start()
    {
        if (playerSpeed > enemySpeed)
        {
            // Adding \n after the first sentence adds a line break
            Debug.Log("You succesfully outrun the enemy and reach safety!\n  .... For now...");
        }
        else
        {
            Debug.Log("The enemy is fleet of foot! It would be wiser to stay and fight!");
        }
    }
    // Changing playerSpeed to 15 makes the first if debug print to Console. Success!
}