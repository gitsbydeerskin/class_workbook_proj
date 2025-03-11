using UnityEngine;

public class WB8_T1 : MonoBehaviour
{
    // Workbook 8 Task 1 = Create an array of type string[] to store multiple NPC dialogue lines, filled with at least three different dialogue lines. Use a loop to iterate through the array and print each dialogue in the Unity console.
    [SerializeField] string[] NPCdxg = new string[4] {"Hello there.", "Have you heard of the Fighter's Guild?", "WHY. WON'T. YOU. DIE!?!?", "Good day."};
    void Start()
    {
        for (int i = 0; i < NPCdxg.Length; i++)
        { 
            Debug.Log(NPCdxg[i]); 
        }
        
    }

    
}
