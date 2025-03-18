using UnityEngine;
/* Task: Temperature Warning System: 
 Declare a float variable temperature and set it to 35.5f.
Write an if-else if-else structure to check conditions:
• If temperature is above 40, print "Warning! It's too hot!".
• If temperature is between 20 and 40, print "The temperature is normal.".
• Otherwise, print "It's cold! Wear a jacket!". */
public class WB6_T6 : MonoBehaviour
{
    [SerializeField] float temp = 35.5f;
    void Start()
    {
        if (temp > 40.0f)
        {
            Debug.Log("Well I guess it's pretty warm out, but you should still probably put some clothes on before I call the Guards!");
        }
        // Originally I tried > || <, but this didn't work. && works for checking if something is between both desired Values
        else if (temp > 20 && temp < 40)
        {
            Debug.Log("Get the Hell out of my store and go enjoy the lovely temperature elsewhere you naked freak!");        
        }
        // else statements cannot have conditionals applied to them. I tried to have the else statements have the (temp > 20 && temp < 40), but Unity got mad at me
        else
        {
            Debug.Log("It's too cold to be walking around like that! I'm calling the Guards!");
        }
    }

}
