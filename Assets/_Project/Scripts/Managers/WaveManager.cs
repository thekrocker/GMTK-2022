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

    public List<GameObject> activeEnemies;

    public static WaveManager Instance;

    private void Awake()
    {
        if (Instance == null) Instance = this;
    }
    
    private void OnEnable()
    {
        Actions.OnUpgraded += SpawnNextWave;
    }

    private void Start()
    {
        SpawnWave();
    }
    
    private void OnDisable()
    {
        Actions.OnUpgraded -= SpawnNextWave;
    }

    public WaveDataSO GetCurrrentWave()
    {
        return waveListSO.waves[_currentWaveIndex % waveListSO.waves.Length];
    }

    public WaveDataSO GetNextWave()
    {
        return waveListSO.waves[(_currentWaveIndex + 1) % waveListSO.waves.Length];
    }

    public void RemoveEnemy(GameObject obj)
    {
        activeEnemies.Remove(obj);

        CheckWaveStatus();
    }

    private void CheckWaveStatus()
    {
        if (activeEnemies.Count > 0) return;

        Debug.Log("Wave ended!");
        Actions.OnWaveEnd?.Invoke();
    }

    private void SpawnWave()
    {
        for (int i = 0; i < GetCurrrentWave().amount; i++)
        {
            float angle = (i * Mathf.PI * 2f) / GetCurrrentWave().amount;

            Vector3 newPos = playerPlayerData.positionValue +
                             new Vector3(Mathf.Cos(angle) * radius, 0f, Mathf.Sin(angle) * radius);

            var spawned = Instantiate(GetCurrrentWave().enemies[i % GetCurrrentWave().enemies.Length], newPos,
                Quaternion.identity);
            spawned.transform.SetParent(enemyParent);
            activeEnemies.Add(spawned);
        }
    }

    private void SpawnNextWave()
    {
        IncreaseWaveIndex();
        SpawnWave();
    }

    private void IncreaseWaveIndex()
    {
        _currentWaveIndex++;
    }
}