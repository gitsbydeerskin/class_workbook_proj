using System;
using UnityEngine;
/* Task 3 = Null Reference Handling
     Handle missing components.
    • Create a cube.
    • Create a script and attach it to the cube.
    • Create the following reference: MeshRender rend; 
    • Leave the GameObject reference null on purpose.
    • Use try-catch to handle NullReferenceException.
    • Try: rend.material.color = color.red; 
    • In catch get the mesh renderer.
    • In Finally change the colour to red.*/
public class WB10_T3 : MonoBehaviour
{
    MeshRenderer rend;
    void Start()
    {
        try
        {
            rend.material.color = Color.red;
        }
        catch (NullReferenceException)
        {
            rend = GetComponent<MeshRenderer>();
        }
        finally
        {
            rend.material.color= Color.red;
            Debug.Log("I am red.");
        }
    }


}
