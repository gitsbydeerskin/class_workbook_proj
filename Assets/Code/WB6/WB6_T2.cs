using UnityEngine;
/* Task: If-Else Statement
  Declare an integer variable player health and set it to 30.
  Use an if statement to check if player health is above 50.
  If true, print "You are ready for battle!".
  If false, use an else statement to print "You need to heal!".  */
public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] int playerHealth = 30;
    void Start()
    {
        if (playerHealth >= 50)
        {
            Debug.Log("Let's get these baddies!");
        }
        else
        {
            Debug.Log("Maybe we should heal first? Drink up!");
        }
    }
    // Changing the playerHealth from 50 to 70 gets the console to print "Let's get these baddies!" succesfully!
}
