using UnityEngine;

public class PlayerPrefsSave : MonoBehaviour
{
    public string playerName;
    public float currentHealth;
    public int level;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void save()
    {
        PlayerPrefs.SetString("CharacterName", playerName);
        PlayerPrefs.SetFloat("CurrentHealth", currentHealth);
        PlayerPrefs.SetInt("Level", level);
    }
    private void Load()
    { //having no data to pull can cause errors so we use an If statement to prevent this
        if (PlayerPrefs.HasKey("CharacterName"))
        {
            playerName = PlayerPrefs.GetString("CharacterName");
            currentHealth = PlayerPrefs.GetFloat("CurrentHealth");
            level = PlayerPrefs.GetInt("Level");
        }
        // An else can be used to prompt the Player to create a character, Load, etc.
    }
    // "Saving and Loading is a bit alien. This is just how it's done." 
    void Start()
    {
        // this would delete just the current health
        PlayerPrefs.DeleteKey("currentHealth");
        // This deletes all the things that aren't Unity-specific.
        PlayerPrefs.DeleteAll();
    }

    // This is only suitable for small amounts of data - so not proper saves or full game data. They are also unencrypted. 
    // It's normally used to check if the game has been set-up correctly on its first-time running and is never used again EVER. 
}
