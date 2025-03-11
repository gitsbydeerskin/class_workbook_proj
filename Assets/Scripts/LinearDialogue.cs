namespace NPC
{
    // Namespaces act as a "Surname" for classes and keep them separate from our other classes.
    // This means the Variables etc within this Namespace will not be molested by other classes.
    using UnityEngine;
    using UnityEngine.UI;
    public class LinearDialogue : MonoBehaviour
    {
        [SerializeField] string[] linesOfDXG = new string[5];
        [SerializeField] Text dxgDisplay;
        [SerializeField] int index = 0;
        [SerializeField] Text buttonDisplay;
        [SerializeField] GameObject dxgPanel;
        void Start()
        {
            dxgDisplay.text = linesOfDXG[index];
            // Button text to say Next
            buttonDisplay.text = "Next";
        }

        // Update is called once per frame
        public void Next()
        {
            if (index < linesOfDXG.Length-1)
            {
                index++;
                dxgDisplay.text = linesOfDXG[index];
                if (index >= linesOfDXG.Length - 1)
                {
                    // Button text to say Bye.
                    buttonDisplay.text = "Erm... That just happened..";
                }
        
            }
            else
            {
                dxgPanel.SetActive(false);
            }
        }
    }
}
