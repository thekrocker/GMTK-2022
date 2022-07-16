using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDataHolder : MonoBehaviour
{
    [SerializeField] private PlayerData playerData;

    private void Start()
    {
        playerData.playerHealth = GetComponent<Health>();
    }

    private void Update()
    {
        playerData.positionValue = transform.position;
    }
}
