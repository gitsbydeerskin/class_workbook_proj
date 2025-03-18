//using UnityEngine;
//UNITY_EDITOR
//public class Function_Example : MonoBehaviour
//{
//   / returnType FunctionName(parameters)
//    {
//        // Code block
//    }
//    // returnType specifies the type of data the function returns, or void if the function doesn't return anything.
//    // FunctionName is the name you give the function. It should describe what it does
//    // (parameters) Variables you send into the function to help it perform its task.
//    // {} The section where the instructions that run once the functions been called
    
//    void Start()
//    {
        
//    }

//    // What is a Return? 
//    // A return type indicates what kind of information a function will give back after it runs. 
///* Types of Returns: 
//        vid: This doesn't return a value. We use this if we don't need the function to return any values.
//                void Jump() {}
//                    A player jumping doesn't need to return a value, so we would use void for this Function.
//        int: This returns an integer value.
//                int GetScore() {return100;}
//                    In this case the value of player's score (100) would be returned. 
//        bool: This returns a true or no value. 
//                    bool IsAlive() {return true;}
//                        In this example, the player is alive, so the function returns a True value.
//        string: Returns a string of text. 
//                    string GetName() {return "Bob";}
//                        This retrives a string of text, in this case the player's name 'Bob'. */


///* To call a function, you call it by using its Name followed by a Parentheses (). 
//        MovePlayer (); 
//            this calls the MovePlayer function
//   If the function requires parameters, you pass them inside the parentheses. These paramateres include necessary information to perform its task.
//        TakeDamage (10);
//            this calls the TakeDamage function and passes the value 10.
//A functioning example of the code is: */

//    void Update()
//{
//        MovePlayer (); // this calls MovePlayer every frame
//        CheckPlayerHealth (); // this calls CheckPlayerHealth every frame
//}

//    /* You can also call functions with return types to store their results in variabls.
//       For example, calling a function that returns a value: */
//            int score = GetScore(); // this calls the GetScore function and stores the returned value in 'score'
//    /* in the above code, GetScore() returns an integer (the player's score), and we store that value in the score variable for later use.
//       When you call functions in Unity, they can be called from other classes, using instances or static methods, depending on how the function is defined. 


//    So why use Functions? Essentially they are containers. Rather than running all of your code in Start, you can have containers of code (Functions).
//    These Functions can be reused over and over. They help to organise and resue code, instead of us having to rewrite code from scratch every time.
//    They can be used for essential tasks such as moving a character, checking their health, spawning enemies, and calculating points. */
    


//}
