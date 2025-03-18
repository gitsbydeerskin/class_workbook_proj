using UnityEngine;

public class WB3_T6 : MonoBehaviour
{
    int aTea = 5;
    int bMilk = 10;
    int tempCup;
    void Start()
    {
        /* Here is where I got stuck. It worked to swap a=10, but b is still also 10.
        temp = a;
        a = b;
        b = a;
        Debug.Log("a: " + a);
        Debug.Log("b: " + b);
        */

        // Tea gets added to the Cup - A's value is assigned to Temp, making them both 5. Note that the SECOND Variable listed is the one that has its Value copied! (This confuses me a bit, and will take some getting used to/take a bit to remember I think)
        tempCup = aTea;
        Debug.Log("aTea: " + aTea);
        Debug.Log("tempCup: " + tempCup);

        // The Milk goes into the Tea - Replaces the value of A with the value of B disturbing the value of A. After this line, B and A have the same value of 10.
        aTea = bMilk;
        Debug.Log("aTea: " + aTea);
        Debug.Log("bMilk : " + bMilk);

        // Pours the Milk into the Cup - Overwrites the value of B with Temp's value of 5, thus swapping it with A's original value! Viola!
        bMilk = tempCup;
        Debug.Log("bMilk : " + bMilk);
        Debug.Log("aTea: " + aTea);

        //Please excuse all the Debug.Logs! They are there so I could ensure what I wanted/thought was happening, was happening!

        /* Originally I used a comment from here as a starting point: 
           https://www.quora.com/What-is-the-actual-logic-behind-swapping-2numbers-with-temporary-variable-The-position-of-temporary-variable-change-output-i-e-temp-a-is-not-a-temp
           But in typical Quora fashion, the structure it provided wasn't actually correct, or maybe I just wasn't able to read it right, but either way, I ended up with B STILL being assigned its original variable. 
           So, I gave ChatGPT the code, and asked why it wasn't working to swap the value of B. 
           ChatGPT tried to tell me I should assign b to b. I corrected it. 
           It fed me back code which would once again result in b = 10, but by that point my brain was finally SEEING the pattern in the code that it needed to seeto figure out the problem on my own :)!! 
           Thanks AIdiot! <- and it had the audicity to say it was a problem with MY code, despite saying it had "fixed" the code. The nerve!
        */

    }


}
