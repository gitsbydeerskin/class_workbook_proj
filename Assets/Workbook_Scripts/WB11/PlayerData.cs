using UnityEngine;
[System.Serializable]

public class PlayerData 
// This is a Global Class which means we can reference PlayerData without needing to attach it to anything.

{
    public string playerName = "Wik";
    public int playerLevel = 25;
    public  float playerHealthMax = 100;
    public float playerCurrentHealth = 75;
    // Usually the playerPostion/Rotation info would be Transform.Postion and Transform.Rotation because the player object would have that information.
    public Vector3 playerPosition = new Vector3(10, 1, 10);
    public Vector3 playerRotation = new Vector3(0, 90, 0);
            // Additionally we would likely have the Camera info. 
        
        // \n puts data on a New Line
}
