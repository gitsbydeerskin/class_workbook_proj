using UnityEngine;
using UnityEngine.UI;

public class ClickerManager : MonoBehaviour
{
    // Value Per Click
    [SerializeField] int basePoints = 1;
    // Score
    [SerializeField] public float score = 0;
    // UI Display for Score
    [SerializeField] Text _scoreDisplay;
    // increase over Time starts at 0 until upgraded
    [SerializeField] int valueOverTime = 0;

    // This is known as a property. It has a Read-Only (Getter) and a Write-Only (Setter). 
    // Get retrives a value, and Set changes the value.

    //public int Increase
    //{
    //    set 
    //    {

    //    }
    //}
    // the timer 
    public float timer = 0;

    private void Update()
    {
        if (valueOverTime > 0)
        {
            // Increments by the time between frames - doing it like this allows us to normalise the time taken between different PC rigs (potato vs NASA computer)
            // They could cheat with this by speeding up the time/game. But they can access any Public variable anyway. We will cover this more next term.
            timer += Time.deltaTime;
            if (timer > 1)
            {
                score += valueOverTime;
                UpdateUI();
                timer = 0;
            }
        }
    }



    // Main Click Button Behaviour
    public void Click()
    {  // Increases Score by Click Value
        score += basePoints;
        UpdateUI();
    }
    // Updates UI 
    public void UpdateUI()
    {
        // C0 sets the value to a currency
        _scoreDisplay.text = $"{score:C0}";
    }
    public void SetPrice(bool isAuto, int value, int price)
    {
        if (isAuto)
        {
            valueOverTime += value;
        }
        else
        {
            basePoints += value;
        }
        score -= price;
        UpdateUI();
    }
}
