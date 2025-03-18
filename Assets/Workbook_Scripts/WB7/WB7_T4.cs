using UnityEngine;

public class WB7_T4 : MonoBehaviour
{
    // Workbook 7 Task 4 = Print items in an array using a Foreach Loop.
    string[] froots = { "Apple", "Banana", "Cherry" };
    void Start()
    {
        foreach (string froot in froots)
        {
            Debug.Log(froot);
        }
    }
   
}
