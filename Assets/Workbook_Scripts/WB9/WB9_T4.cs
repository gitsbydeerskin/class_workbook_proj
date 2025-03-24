using UnityEngine;

public class WB9_T4 : MonoBehaviour
{
    public int age = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Originally I didn't have temp being called up here, so when I tried to Debug it, it didn't work.
        // By declaring a new String with the new Temp from the result of the Function, I'm able to use it in the Debug Log.
        string temp2 = GetAgeCategory(age);
        Debug.Log($"Dr. House: You are " + temp2 + ".");
    }
    string GetAgeCategory(int howOld)
    {
        string temp = "";
            // this is a Global variable. It can be accessed by any of the Statements within this function.
        if (howOld <= 12)
        {
            temp = "a child";
            // this sets the value of the string variable to equal 'child'. 
        }
        else if (howOld >12 && howOld < 18)
            // this uses && to check if they are between the range of 12 and 18.
        {
            temp = "a teenager";
        }
        else 
        {
            temp = "an adult";
        }
        return temp;
        // this returns the new value of the string variable named 'temp' based on the if conditions. 
    }
    
}
