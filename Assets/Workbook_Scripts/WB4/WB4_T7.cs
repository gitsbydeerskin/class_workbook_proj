using UnityEngine;

public class WB4_T7 : MonoBehaviour
{
    // Workbook 4 Task 7 = Use String Interpolation to show name and health.
    string charName = "Ripley";
    int health = 100;
    string info;
    void Start()
    {
        info = $"{charName}'s current health is at {health}.";
        Debug.Log(info);
    }

   
}
