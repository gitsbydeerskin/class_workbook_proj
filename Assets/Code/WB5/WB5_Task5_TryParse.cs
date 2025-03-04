using UnityEngine;

public class WB5_Task5_TryParse : MonoBehaviour
{
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
            Debug.Log("Oops! That didn't work! Why don't you try again!");
        }
    }


}
