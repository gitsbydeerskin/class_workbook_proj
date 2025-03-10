using UnityEngine;

public class WB4_T5 : MonoBehaviour
{
    // Workbook 4 Task 5: Dynamic score display using String Formatting.
    string charName = "Ripley";
    int score = 18;
    string formattedString;

    void Start()
    {
        formattedString = string.Format("{0}: So far I've taken out {1} of these monsters..!", charName, score);
        Debug.Log(formattedString);   
    }

  
}
