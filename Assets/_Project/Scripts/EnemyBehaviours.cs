using System;
using System.Collections;
using System.Collections.Generic;
using _Project.Scripts;
using UnityEngine;
using UnityEngine.AI;

public abstract class EnemyBehaviours : MonoBehaviour
{
    [SerializeField] protected EnemyStats stats;
    [SerializeField] protected PlayerData playerPlayerData;

    private NavMeshAgent _agent;

    private void Awake()
    {
        _agent = GetComponent<NavMeshAgent>();
        
        SetSpeed();
    }
    
    

    public void SetSpeed()
    {
        _agent.speed = stats.speed;
    }

    public virtual void Chase()
    {
        _agent.SetDestination(playerPlayerData.positionValue);
    }

    public void StopAgent(bool status)
    {
        _agent.isStopped = status;
    }

    public void Look()
    {
        transform.LookAt(playerPlayerData.positionValue);
    }

    public virtual void OnDisable()
    {
        WaveManager.Instance.RemoveEnemy(gameObject);
        ParticleManager.Instance.PlayDieParticle(transform);
    }

    public abstract void Attack();
    public abstract void Die();


    public bool IsInAttackRange()
    {
        return Vector3.Distance(transform.position, playerPlayerData.positionValue) < stats.attackRange;
    }
}