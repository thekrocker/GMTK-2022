using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleManager : MonoBehaviour
{
    [SerializeField] private GameObject dieParticle;

    
    public static ParticleManager Instance;
    private void Awake()
    {
        if (Instance == null) Instance = this;
    }

    public void PlayDieParticle(Transform targetTransform)
    {
        Instantiate(dieParticle, targetTransform.position, Quaternion.identity);
    }
}
