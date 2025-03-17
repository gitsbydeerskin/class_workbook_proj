using UnityEngine;
/* Task: Unlocking a Door with a Key: 
    Declare a boolean variable has key and set it to false.
    Write an if statement that checks if has key is true.
    • If true, print "You unlocked the door!".
    • Otherwise, print "You need a key to open this door!". */
public class WB6_T5 : MonoBehaviour
{
  [SerializeField] bool hasKey = true;
    void Start()
    {
        if (hasKey == true)
        {
            Debug.Log("You check the key and ... IT WORKS!");
        }
        else
        {
            Debug.Log("You check the key... It's not the right one!");
        }
    }
    // Setting haskey to true reads the first conditional debug
}
