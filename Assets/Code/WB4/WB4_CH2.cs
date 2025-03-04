using UnityEngine;

public class WB4_CH2 : MonoBehaviour
{
    string firstName = "Dave";
    string greeting = "Hello,";
    string sentence;
    void Start()
    {
        sentence = greeting + " " + firstName;
        Debug.Log(sentence);
    }

}