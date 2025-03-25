using System;
using UnityEngine;
using UnityEngine.UI;

public class ClickerUpgrade : MonoBehaviour
{
    [Serializable]
    public struct ClickerUpgradeOptions
    {
        public string name;
        public string description;
        public int value;
        public int price;
        // This has been added to work with Clicker Manager's Property
        public bool isAuto;
        public Text UI;
        public Button button;
    }
    // This array can be accessed and filled out from the Inspector window. Once we've filled it out, we can come back to our code and use the Upgrade indexes to actually apply it.
    public ClickerUpgradeOptions[] options;
    public ClickerManager manager;

    public void Upgrade(int index)
    {
        if (manager.score >= options[index].price)
            {
                // Commented out so the Function in Clicker Manager can handle these
                //manager.score -= options[index].price;
                //manager.basePoints += options[index].value;
                options[index].value++;
                options[index].price *= 2;
                //manager.UpdateUI();
            }
    }
}
