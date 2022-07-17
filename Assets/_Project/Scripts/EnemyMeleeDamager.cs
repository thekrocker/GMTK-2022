using System.Collections;
using System.Collections.Generic;
using _Project.Scripts;
using UnityEngine;

public class EnemyMeleeDamager : MonoBehaviour
{
    [SerializeField] private EnemyStats stats;
    [SerializeField] private PlayerData playerData;
    
    public void Damage()
    {
        playerData.playerHealth.DecreaseHealth(stats.damage);
    }
}
