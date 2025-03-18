using UnityEngine;

/* Workbook 9 Task 1 = Return Type: void - Print Player Health :
     Create a function named PrintPlayerHealth() that takes an integer representing the
     player's health and outputs "Player Health: [health]" in the console. 
     The function should not return anything */
public class WB9_T1 : MonoBehaviour
{
    /* Below is my attempt at trying to figure this task out
    int playerHealth = 100;
    
   
    void Start()
    {
        int playerHealth() 
        { 
            return playerHealth; 
        }
    }

    */

    // Here is the class example: 
    int _health = 75;
    void Start()
    {
        PrintPlayerHealth(0);
        PrintPlayerHealth(_health);
    }
    void PrintPlayerHealth(int valueIn)
    {
        Debug.Log($"Player Health: {valueIn}");
    }

}
