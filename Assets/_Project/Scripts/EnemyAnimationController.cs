using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnimationController : MonoBehaviour
{
    private Animator _animator;
    
    private static readonly int Attack = Animator.StringToHash("isAttacking");
    private static readonly int Die = Animator.StringToHash("Die");

    void Awake()
    {
        _animator = GetComponentInChildren<Animator>();
    }
    

    public void HandleAttackAnimation(bool status)
    {
        _animator.SetBool(Attack, status);
    }

    
    public void PlayDieAnimation()
    {
        _animator.SetTrigger(Die);

    }
}
