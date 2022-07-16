using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour, IDamageable
{
    private float _currentHealth;
    
    public float maxHealth = 100f;
    public float Ratio => _currentHealth / maxHealth;
    
    public UnityEvent OnHealthZero;
    
    void Start()
    {
        _currentHealth = maxHealth;
    }

    public void DecreaseHealth(int damage)
    {
        _currentHealth -= damage;

        if (_currentHealth <= 0)
        {
            _currentHealth = 0;
            OnHealthZero?.Invoke();
        }
    }
    
    public void Heal(int heal)
    {
        _currentHealth += heal;
        if (_currentHealth >= maxHealth)
        {
            _currentHealth = maxHealth;
        }
    }
}