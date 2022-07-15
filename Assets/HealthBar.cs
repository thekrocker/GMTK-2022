using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Sirenix.OdinInspector;

public class HealthBar : MonoBehaviour
{
   public float CurrentHealth;
   public Image healthBar;
   public float MaxHealth = 100f;
   void Start() 
   {
    CurrentHealth = MaxHealth;
   }
   void Update() 
   {
    SetBar();
   }
   public void SetBar()
   {
    healthBar.fillAmount = (float)CurrentHealth / (float)MaxHealth;
   }

    [Button("Decrease!")]
   public void DecreaseHealth(int damage)
   {
    CurrentHealth -= damage;
   }
}
