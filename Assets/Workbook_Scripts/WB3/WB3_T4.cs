using Unity.VisualScripting;
using UnityEngine;

public class WB3_T4 : MonoBehaviour
{
    //Originally I only had int "a" here.

    int a = 1;
    int b = 1;

    /* Part of my Original Code
    int sumOne;
    int sumTwo;
    */

    void Start()
    {
        //But when it came to this part, sumTwo simply took 1 away from the new value of sumOne, instead of the original value of int a. So, I added in int b.

        /* More of the Original Code
        sumOne = a += 2;
        sumTwo = b -= 1;
        Debug.Log(sumOne);
        Debug.Log(sumTwo);
        */

        //This did what I wanted, but Zach said I could do it a lot shorter. I didn't excactly get what he meant, so I just added the values + statements all into the Debug.Log, which I had forgotten you could do until I talked to him.

        /*Zach's suggestion was to add: 
        b -= 1; on this line */

        Debug.Log(b -= 1);
        Debug.Log(a += 2);

        //This does the SAME as ALLLL of the above code, but with WAY less code. And it isn't even what Zach meant.
    }

}
