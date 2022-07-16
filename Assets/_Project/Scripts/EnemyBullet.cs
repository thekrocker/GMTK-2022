using UnityEngine;

namespace _Project.Scripts
{
    public class EnemyBullet : BaseBullet
    {
        [SerializeField] private EnemyStats stats;
        
        public override void Fire(Vector3 point)
        {
            _rb.AddForce(point * stats.projectileSpeed, ForceMode.Impulse);
        }
    }
}