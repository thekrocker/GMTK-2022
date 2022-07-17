using _Project.Scripts;
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour, IDamageable
{
    [SerializeField] private BaseStats stats;

    private float _currentHealth;

    public float Ratio => _currentHealth / stats.initialHealth;

    public UnityEvent OnHealthZero;

    void Start()
    {
        _currentHealth = stats.initialHealth;
    }

    public void DecreaseHealth(int damage)
    {
        _currentHealth -= damage;

        if (!(_currentHealth <= 0)) return;

        _currentHealth = 0;
        OnHealthZero?.Invoke();
    }

    public void Heal(int heal)
    {
        _currentHealth += heal;
        if (_currentHealth >= stats.initialHealth)
        {
            _currentHealth = stats.initialHealth;
        }
    }
}