using UnityEngine;

public class WB4_T3: MonoBehaviour
{
    // Workbook 4 Task 3: Concatenate 3 separate strings into a complete sentence.
    string first = "[TRANSMISSION START] DAVE: It's hollow...";
    string second = ".. and it goes on forever..";
    string third = " and... My god!.. It's full of stars..! [TRANSMISSION END]";
    string lastSignal;
    void Start()
    {
        //The "" in between the + operator signifies if I want a space in between my strings (sentences). 
        lastSignal = first + "" + second + " " + third;
        Debug.Log(lastSignal);
    }

    
}
