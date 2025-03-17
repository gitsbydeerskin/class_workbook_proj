using UnityEngine;
/* Task: Create a C# script called ShootingSystem.
    Declare an integer variable ammo count and set it to 3.
    Write an if-else structure:
    • If ammo count is less than 0
        o print "Bang! You fired a shot!" and decrease ammo count by 1.
    • Otherwise, print "No ammo left!". */
public class WB6_T7 : MonoBehaviour
{
    [SerializeField] int ammoCount = 3;
    void Start()
    {
        // == means Equal To 
        if (ammoCount < 0)
        {
            Debug.Log("You're out! You need to find some ammo!");

        }
  
    }


}
