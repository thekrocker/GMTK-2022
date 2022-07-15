using System;
using System.Collections;
using System.Collections.Generic;
using _Project.Scriptable_Objects.Scripts;
using _Project.Scripts;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.InputSystem;

public class ShootingController : MonoBehaviour
{
    [Title("References")] [SerializeField] private Bullet bullet;
    [SerializeField] private Transform shootingPoint;

    [Title("Properties")] [SerializeField] private PlayerStats stats;

    private bool _canShoot = true;

    private bool _startedShooting;

    private PlayerController _playerController;

    private void Awake()
    {
        _playerController = GetComponent<PlayerController>();
    }

    private void Start()
    {
        _playerController.PlayerControls.Player.Shoot.performed += StartShooting;
        _playerController.PlayerControls.Player.Shoot.canceled += EndShooting;
    }

    private void EndShooting(InputAction.CallbackContext obj) => _startedShooting = false;
    private void StartShooting(InputAction.CallbackContext obj) => _startedShooting = true;

    private void Update()
    {
        if (!_startedShooting) return;
        
        SpawnBullet();
    }


    public void SpawnBullet()
    {
        if (!_canShoot) return;

        var spawnedBullet = Instantiate(bullet, shootingPoint.position, shootingPoint.rotation);
        spawnedBullet.Fire(shootingPoint.forward);
        StartCoroutine(CO_ShootCooldown());
    }

    public IEnumerator CO_ShootCooldown()
    {
        _canShoot = false;
        yield return new WaitForSeconds(stats.attackInterval);
        _canShoot = true;
    }
}