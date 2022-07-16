using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Sirenix.OdinInspector;

public class Health : MonoBehaviour
{
    public float CurrentHealth;
    public float MaxHealth = 100f;
    public float Ratio => CurrentHealth / MaxHealth;

    void Start()
    {
        CurrentHealth = MaxHealth;
    }

    public void DecreaseHealth(int damage)
    {
        CurrentHealth -= damage;
        if (CurrentHealth <= 0)
        {
            Debug.Log("Death!");
        }
    }


    public void HealHealth(int heal)
    {
        CurrentHealth += heal;
        if (CurrentHealth >= MaxHealth)
        {
            CurrentHealth = MaxHealth;
        }
    }
}