using System;
using _Project.Scripts;
using _Project.Scripts.Managers;
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour, IDamageable
{
    [SerializeField] private BaseStats stats;

    private float _currentHealth;

    public float Ratio => CurrentHealth / stats.initialHealth;

    public float CurrentHealth
    {
        get => _currentHealth;
        set
        {
            _currentHealth = value;
            OnHealthChanged?.Invoke();
        }
    }

    public Action OnHealthChanged;

    public UnityEvent OnHealthZero;

    void Start()
    {
        CurrentHealth = stats.initialHealth;
    }


    private void OnEnable()
    {
        Actions.OnUpgraded += FullHeal;
    }

    private void OnDisable()
    {
        Actions.OnUpgraded -= FullHeal;
    }

    public void DecreaseHealth(int damage)
    {
        CurrentHealth -= damage;

        if (!(CurrentHealth <= 0)) return;

        CurrentHealth = 0;
        OnHealthZero?.Invoke();
    }

    public void Heal(int heal)
    {
        CurrentHealth += heal;
        if (CurrentHealth >= stats.initialHealth)
        {
            CurrentHealth = stats.initialHealth;
        }
    }

    public void FullHeal()
    {
        CurrentHealth = stats.initialHealth;
    }
}