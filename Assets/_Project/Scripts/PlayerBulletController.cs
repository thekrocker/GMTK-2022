using System.Collections;
using _Project.Scriptable_Objects.Scripts;
using _Project.Scripts;
using _Project.Scripts.Utils;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerBulletController : MonoBehaviour
{
    [Title("References")] [SerializeField] private PlayerBullet playerBullet;
    [SerializeField] private Transform shootingPoint;
    [Title("Properties")] [SerializeField] private PlayerStats stats;

    private bool _canShoot = true;

    private bool _startedShooting;

    private static ObjectPooling<PoolObject> _bulletPool;

    private PlayerController _playerController;

    private void Awake()
    {
        _playerController = GetComponent<PlayerController>();

        SetPool();
    }

    private void SetPool()
    {
        _bulletPool = new ObjectPooling<PoolObject>(playerBullet.gameObject, OnPull, OnPush, 30);
    }

    private void OnPush(PoolObject obj)
    {
        obj.GetComponent<PlayerBullet>().ResetVelocity();
    }

    private void OnPull(PoolObject obj)
    {
        obj.GetComponent<PlayerBullet>().InvokePush();
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
        var spawnedBullet = _bulletPool.Pull();
        spawnedBullet.transform.position = shootingPoint.position;
        spawnedBullet.transform.rotation = shootingPoint.rotation;

        var bulletComponent = spawnedBullet.GetComponent<PlayerBullet>();
        bulletComponent.Fire(shootingPoint.forward);

        StartCoroutine(CO_ShootCooldown());
    }

    public IEnumerator CO_ShootCooldown()
    {
        _canShoot = false;
        yield return new WaitForSeconds(stats.attackInterval);
        _canShoot = true;
    }
}