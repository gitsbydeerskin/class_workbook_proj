using UnityEngine;

public class WB5_T5 : MonoBehaviour
{
    // Workbook 5 Task 5 = Write a script that asks for user input and converts it into an int using TryParse. If the input isn't valid, it should print an error message using Debug.Log.
    public string playerInput = "123";
    void Start()
    {
        //this tries to convert the Player Input to the desired Output
        if (int.TryParse(playerInput, out int convertedStringToNumber))
        {
            //if it was successful, this will present the Output in the console
            Debug.Log(convertedStringToNumber);
        }
        //If it wasn't successful, the game would error without a failsafe like this: 
        else
        {
            //This tells the console that it broke
            Debug.Log("Oops! That didn't work! Want to try again?");
        }
    }


}
