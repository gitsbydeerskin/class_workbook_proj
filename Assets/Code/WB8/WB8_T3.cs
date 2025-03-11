using System.Collections.Generic;
using UnityEngine;

public class WB8_T3 : MonoBehaviour
{
    // Task = Delcare a Dictionary<string, int> to store player stats (e.g., health, mana, attack power). Print each stat to the console. Modify one stat and pritn the updated value.
    Dictionary<string, int> playerStats = new Dictionary<string, int>();
    void Start()
    {
        playerStats["Health"] = 576;
        playerStats["Mana"] = 240;
        playerStats["Damage"] = 100;
        playerStats["Level"] = 10;
        foreach (var item in playerStats)
        {
            Debug.Log($"Your current: {item}");
        }
    }
}
