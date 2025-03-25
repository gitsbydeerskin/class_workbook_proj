using System;
using UnityEngine;
/* Task 1 = Divide by Zero
    Handle division by zero in player scoring.
    • Create a script that divides a player's score by their number of lives.
    • Use try-catch to handle a potential DivideByZeroException.
    • In catch, display a warning in the console.
    • In finally, show a message that the operation has finished.*/
public class WB10_T1 : MonoBehaviour
{
    int playerLives = 0;
    int playerScore = 30;
    string Player = "Goobert";
    int dumbumb;
    void Start()

    {
        try
        {
            int dumdumb = playerScore / playerLives;
            Debug.Log($"Hi {Player} your total score is {dumbumb}.");
        }
        catch (DivideByZeroException) 
        {
            Debug.Log("Oops! We tried to divide by 0 and that doesn't make any sense!");
        }   
        finally
        {
            Debug.Log($"Finished mathing! Your total score is {playerScore}. Good job {Player}!");
        }
    }


}
