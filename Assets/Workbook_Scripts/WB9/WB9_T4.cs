using UnityEngine;

public class WB9_T4 : MonoBehaviour
{
    public int age = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GetAgeCategory(age);
    }
    string GetAgeCategory(int howOld)
    {
        string temp = "";
            // this is a Global variable. It can be accessed by any of the Statements within this function.
        if (howOld <= 12)
        {
            temp = "Child";
            // this sets the value of the string variable to equal 'child'. 
        }
        else if (howOld >12 && howOld < 18)
            // this uses && to check if they are between the range of 12 and 18.
        {
            temp = "Teen";
        }
        else 
        {
            temp = "Adult";
        }
        return temp;
        // this returns the new value of the string variable named 'temp' based on the if conditions. 
    }
    
}
