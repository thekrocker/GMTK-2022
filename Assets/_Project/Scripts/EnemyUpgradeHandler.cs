using System;
using System.Collections;
using System.Collections.Generic;
using _Project.Scripts.Managers;
using UnityEngine;

public class EnemyUpgradeHandler : MonoBehaviour
{
    private void OnEnable()
    {
        Actions.OnUpgradeDamage += UpgradeDamage;
        Actions.OnUpgradeHealth += UpgradeHealth;
        Actions.OnUpgradeMovementSpeed += UpgradeMovementSpeed;
        Actions.OnUpgradeWaveCount += UpgradeWaveCount;
    }

    private void OnDisable()
    {
        Actions.OnUpgradeDamage -= UpgradeDamage;
        Actions.OnUpgradeHealth -= UpgradeHealth;
        Actions.OnUpgradeMovementSpeed -= UpgradeMovementSpeed;
        Actions.OnUpgradeWaveCount -= UpgradeWaveCount;
    }

    private void UpgradeWaveCount()
    {
        // Upgrade WaveCount...
    }

    private void UpgradeMovementSpeed()
    {
    }

    private void UpgradeHealth()
    {
    }

    private void UpgradeDamage()
    {
    }
}
