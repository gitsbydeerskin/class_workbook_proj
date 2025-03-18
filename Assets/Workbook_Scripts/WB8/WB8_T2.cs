using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;

public class WB8_T2 : MonoBehaviour
{
    // Workbook 8 Task 2 = Declare a List<string> to store 3 items. Remove one item and print the updated list to the console.
    
    void Start()
    {
        List<string> inv = new List<string >() {"10x Health Potions", "240x Orc Teeth", "1x Heroe's Sword"};
        {
            Debug.Log($"{inv[2]}, {inv[0]} and {inv[1]} left in Inventory.");
            Debug.Log(inv[2] + " equipped!");
            Debug.Log($"{inv[2]} removed from Inventory");
            inv.Remove("1x Heroe's Sword");
            Debug.Log($"{inv[0]} and {inv[1]} left in Inventory.");
        }
    }

   
}
