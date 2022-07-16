using System;
using _Project.Scripts.Utils;
using UnityEngine;

namespace _Project.Scripts
{
    public class EnemyBulletController : MonoBehaviour
    {
        [SerializeField] private Transform shootingPoint;
        [SerializeField] private EnemyStats stats;


        public void SpawnBullet()
        {
            var spawnedBullet = BulletPoolManager.Instance.BulletPool.Pull();

            spawnedBullet.transform.position = shootingPoint.position;
            spawnedBullet.transform.rotation = shootingPoint.rotation;
            var bulletComponent = spawnedBullet.GetComponent<EnemyBullet>();
            bulletComponent.Fire(shootingPoint.forward);
            
            
            spawnedBullet.transform.SetParent(BulletPoolManager.Instance.EnemyBulletParent);
        }
    }
}