using System;
using UnityEngine;
/* Task 2 = Array Index Out of Range 
     Safely access player data in an array.
    • Create an array of player names or scores.
    • Ask the player (via the Inspector or hard-coded) for an index.
    • Use try-catch to handle an IndexOutOfRangeException.
    • In finally, log "Array access complete!" */
public class WB10_T2 : MonoBehaviour
{
    string birthdayBoy = "Michael";
    string[] birthdayGifts = new string[3] { "cake", "ice cream", "presents" }; 
    void Start()
    {
        Debug.Log($"{birthdayBoy} it's your birthday today! What present would you like buddy?");
        try
        {
            Debug.Log(birthdayGifts[4]);
        }
        catch (IndexOutOfRangeException)
        {
            Debug.Log($"Haha sorry buddy, the Giant Rat that make all of the rules isn't an option today!\n Why don't you try picking {birthdayGifts[0]}, {birthdayGifts[1]}, or {birthdayGifts[2]} instead?");
        }
        finally
        {
            Debug.Log($"Good pick little buddy! Happy birthday {birthdayBoy}");
        }
    }

 
}
