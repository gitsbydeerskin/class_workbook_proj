using UnityEngine;

public class Workbook4Ch1 : MonoBehaviour
{
    string firstName = "Dave";
    string response = "I can't let you do that";
    string sentence;

    void Start()
    {
        sentence = response + " " + firstName;
        Debug.Log(sentence);
    }

}


