using UnityEngine;
// ALL TEXT FILES NEED TO COME FROM THIS SYSTEM: 
using System.IO;

  
  

public class TextSave : MonoBehaviour
{
    string filePath;
    private PlayerData data;
    public PlayerData player;
    public string position;
    public string rotation;
    void WriteTextFile(string content)
        // This is the SAVE function without a Return type
    {
        File.WriteAllText(filePath, content);
    }
    string ReadTextFile()
        // This is the LOAD function with a String Return type. All data written into a Save file is formatted as a String, so the Load function must Return the String Value. 
    {
        return File.ReadAllText(filePath);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    // Everything in Unity is private by default. This is  from Intellisense trying to be smart. 
    {
      
        //string saveDate = $"{data.playerName}\n{data.playerLevel}\n{data.playerHealthMax}\n{data.playerCurrentHealth}\n{data.playerPosition}\n{data.playerRotation}";
        string saveData = $"{data.playerName}|{data.playerLevel}|{data.playerHealthMax}|{data.playerCurrentHealth}|{data.playerPosition}|{data.playerRotation}";

        // This sets the location and the file name, so when we make the file or edit the file it knows where and what we're editing. 
        filePath = $"{Application.dataPath}/PlayerData.txt";

        // WriteTextFile("This is content");
        WriteTextFile(saveData);    
        Debug.Log(ReadTextFile());
        Load();

        void Load()
        {
            string[] loadedData = ReadTextFile().Split('|');
            player.playerName = loadedData[0];
            player.playerLevel = int.Parse(loadedData[1]);
            player.playerHealthMax = int.Parse(loadedData[2]);
            player.playerCurrentHealth= int.Parse(loadedData[3]);

            position = loadedData[4].Trim('(');
            position = position.Trim('(');
            string[] values = position.Split(',');
            player.playerPosition.x = float.Parse(values[0]);
            player.playerPosition.y = float.Parse(values[1]);
            player.playerPosition.z = float.Parse(values[1]);

            //player.transform.position = player.playerPosition;

            rotation = loadedData[5].Trim('(');
            rotation = rotation.Trim('(');
            string[] rotValues = rotation.Split(',');
            player.playerRotation.x = float.Parse(values[0]);
            player.playerRotation.y = float.Parse(values[1]);
            player.playerRotation.z = float.Parse(values[1]);

            //player.transform.eulerAngles = (player.playerRotation);
        }
    }
    
 
}
