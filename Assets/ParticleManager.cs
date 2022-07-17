using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleManager : MonoBehaviour
{
    [SerializeField] private GameObject dieParticle;
    [SerializeField] private GameObject bulletHitParticle;
    [SerializeField] private GameObject hasbullahParticle;

    
    public static ParticleManager Instance;
    private void Awake()
    {
        if (Instance == null) Instance = this;
    }

    public void PlayDieParticle(Transform targetTransform)
    {
        Instantiate(dieParticle, targetTransform.position, dieParticle.transform.rotation);
    }

    public void PlayBulletHitParticle(Transform target)
    {
        Instantiate(bulletHitParticle, target.position, bulletHitParticle.transform.rotation);
    }

    public void PlayHasbullahParticle(Transform target)
    {
        Instantiate(hasbullahParticle, target.position, bulletHitParticle.transform.rotation);

    }
}
