using UnityEngine;

public class WB4_T8 : MonoBehaviour
{
    // Workbook 4 Task 8 = Use String Interpolation to display a player's name and current health, taken out of the max health as a percentage.
    string charName = "Ripley";
    int currentH = 50;
    int maxH = 100;

    void Start()
    {
        /* Calculate the health percentage.
           (float)currentH = Uses Type Casting to convert CurrentH from an int into a float to allow decimal calculations.
           (float)currentH / maxH = Using division, this divides 50.0 / 100, for a result of 0.50
           * 100 = Converts the decimal fraction into a percentage. */
        float healthPercent = (float)currentH / maxH * 100;
        // healthPercent now stores 50.0 instead of 100.

        // The below uses string interpolation to display player status. I learned a little about formatting because I wanted it to display percent simples.

        /* :F0 is a format specifier in String Interpolation. 
           F = Fixed-Point Notation (decimal format)
           0 = the number of decimal places to show.
           F1, F2, etc, would show 50.0, 50.00, etc. */ 

        Debug.Log($"{charName} has {healthPercent:F0}% health remaining out of a total of {maxH:F0}%.");
    }

}
