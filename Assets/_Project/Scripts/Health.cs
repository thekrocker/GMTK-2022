using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour, IDamageable
{
    public float CurrentHealth;
    public float MaxHealth = 100f;
    public float Ratio => CurrentHealth / MaxHealth;
    
    public UnityEvent OnHealthZero;
    
    void Start()
    {
        CurrentHealth = MaxHealth;
    }

    public void DecreaseHealth(int damage)
    {
        CurrentHealth -= damage;

        if (CurrentHealth <= 0)
        {
            CurrentHealth = 0;
            OnHealthZero?.Invoke();
        }
    }
    
    public void Heal(int heal)
    {
        CurrentHealth += heal;
        if (CurrentHealth >= MaxHealth)
        {
            CurrentHealth = MaxHealth;
        }
    }
}