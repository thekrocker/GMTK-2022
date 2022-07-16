using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationController : MonoBehaviour
{
    private static readonly int IsMoving = Animator.StringToHash("isMoving");

    [SerializeField] private Animator animator;

    private PlayerController _controller;

    private void Awake()
    {
        _controller = GetComponent<PlayerController>();
    }

    private void Update()
    {
        HandleAnimation();
    }

    public void HandleAnimation()
    {
        if (_controller.GetMovementVector() != Vector3.zero)
        {
            animator.SetBool(IsMoving, true);
        }
        else
        {
            animator.SetBool(IsMoving, false);
        }
    }
}