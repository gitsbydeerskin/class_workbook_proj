using UnityEngine;

public class WB7_T2 : MonoBehaviour
{
    // Workbook 7 Task 2 = Simulate asking for a correct number between 1-5, display a congratulations message if the correct number is succesfully picked. Use Do-While Loop and Random.Range.
    int correct = 3;
    int rando;
    void Start()
    {
        Debug.Log("LET'S GO GAMBLING!!!!!!!!!!");
        do
        {
            rando = Random.Range(0, 20);
            // This is useless Random.Range (0, 6 );
            Debug.Log(rando);
            if (rando != correct)
            { Debug.Log("AW DANG IT"); }
        } 
        // This tells the code that if rando is NOT equal to Correct to Loop again
        while (rando != correct);
        Debug.Log("YiPPEE YOU WON!!!");
    }

    
}
