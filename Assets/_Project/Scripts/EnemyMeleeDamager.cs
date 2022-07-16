using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMeleeDamager : MonoBehaviour
{
    [SerializeField] private int damage;
    [SerializeField] private PlayerData playerData;
    
    public void Damage()
    {
        playerData.playerHealth.DecreaseHealth(damage);
    }
}
