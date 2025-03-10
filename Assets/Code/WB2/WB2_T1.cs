using UnityEngine;

public class WB2_T1 : MonoBehaviour
{
    /*
    private int _score = 10;
    private float _timer = 2.5f;
    private string _name = "Kevin";
    private char _singleCharacter = 'K';
    private bool _isGameOver = false;
    */
    public int playerLevel = 5;
    public float time = 2.2f;
    //why are strings in "" but chars have to be in ' ' it confuses me 
    public string playerName = "Jermie";
    public char singleLetter = 'J';
    public bool isGameRunning = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(playerLevel);
        Debug.Log(time);
        Debug.Log(playerName);
        Debug.Log(singleLetter);
        Debug.Log(isGameRunning);
    }

    // Update is called once per frame
    
}
