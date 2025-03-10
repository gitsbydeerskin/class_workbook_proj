using UnityEngine;

public class WB4_T4 : MonoBehaviour
{
    // Worbook 4 Task 4: Age & Name display using String Formatting.
    string charName = "Ripley";
    int age = 30;
    string formattedString;

    void Start()
    {
        formattedString = string.Format("This is {0}, third officer reporting. {1} years of age.", charName, age);
        Debug.Log(formattedString);
    }

   
}
