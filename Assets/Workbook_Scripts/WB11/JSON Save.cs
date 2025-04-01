using UnityEngine;
using System.IO;

public class JSONSave : MonoBehaviour
{
    string filePath;
    public PlayerData dataToLoad;
  

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PlayerData dataToSave = new PlayerData
        {
            playerName = "Kevin",
            playerLevel = 1,
            playerHealthMax = 10,
            playerCurrentHealth = 3,
            playerPosition = new Vector3(0, 1, 1),
            playerRotation = new Vector3(0, 15, 0),
        };

        filePath = $"{Application.dataPath}/PlayerData.json";
        //SaveJSON(dataToSave);
        //LoadData();
        dataToLoad = LoadData();
    }

    // Update is called once per frame
    void SaveJSON(PlayerData data)
    {
        string LineToSave = JsonUtility.ToJson(data);
        File.WriteAllText(filePath, LineToSave);    
    }
    PlayerData LoadData()
    { 
        string LoadedData = File.ReadAllText(filePath);
        return JsonUtility.FromJson<PlayerData>(LoadedData);    
    }
    //void sendToPlayer(PlayerData data)
    //{ 
    //    dataToLoad.playerName = data.playerName;
    //    dataToLoad.playerLevel = data.playerLevel;
    //    dataToLoad.playerCurrentHealth = data.playerCurrentHealth;
    //    dataToLoad.playerHealthMax = data.playerHealthMax;
    //    dataToLoad.playerRotation = data.playerRotation;
    //    dataToLoad.playerPosition = data.playerPosition;

    //    dataToLoad.transform.position = data.playerPosition;
    //    dataToLoad.transform.eulerAngles = data.playerRotation;
    //}    
}
