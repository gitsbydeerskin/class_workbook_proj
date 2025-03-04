namespace Player
{

    using UnityEngine;
    using UnityEngine.UI;

    public class PlayerHealth : MonoBehaviour
    {
        [SerializeField] float _currentHealth = 100;
        [SerializeField] float _maxHealth = 100;
        [SerializeField] Image _healthBar;

        void Start()
        {
            _healthBar.fillAmount = Mathf.Clamp01(_currentHealth/ _maxHealth);
        }


        void Update()
        {
            //if the health bar display aount is not the same as our current health percentage
            if (_healthBar.fillAmount != Mathf.Clamp01(_currentHealth / _maxHealth))
            {
                //Update
                Debug.Log("Controlled");
                _healthBar.fillAmount = Mathf.Clamp01(_currentHealth / _maxHealth);
            }

            Debug.Log("Not Controlled");    
            //_healthBar.fillAmount = Mathf.Clamp01(_01currentHealth / _maxHealth);
        }
    }
}