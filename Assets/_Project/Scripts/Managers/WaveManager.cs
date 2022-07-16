using System;
using System.Collections;
using System.Collections.Generic;
using _Project.Scripts.Managers;
using Sirenix.OdinInspector;
using UnityEngine;

public class WaveManager : MonoBehaviour
{
    [SerializeField] private WaveListSO waveListSO;
    [SerializeField] private float radius;
    [SerializeField] private PlayerData playerPlayerData;
    [SerializeField] private Transform enemyParent;
    
    private int _currentWaveIndex;
    
    private WaveDataSO GetCurrrentWave()
    {
        return waveListSO.waves[_currentWaveIndex];
    }
    

    [Button("Spawn")]

    private void SpawnEnemies()
    {
        for (int i = 0; i < GetCurrrentWave().amount; i++)
        {
            float angle = (i * Mathf.PI*2f) / GetCurrrentWave().amount;
            
            Vector3 newPos = playerPlayerData.positionValue + new Vector3(Mathf.Cos(angle) * radius, 0f, Mathf.Sin(angle) * radius);
            
            var spawned = Instantiate(GetCurrrentWave().enemies[i % GetCurrrentWave().enemies.Length], newPos, Quaternion.identity);
            spawned.transform.SetParent(enemyParent);
        }
    }
    
    
    
    
    
    
}
