using System;

namespace _Project.Scripts
{
    public class RangeEnemyBehaviours : EnemyBehaviours
    {
        private EnemyBulletController _bulletController;

        private void Start()
        {
            _bulletController = GetComponent<EnemyBulletController>();
        }

        public override void Chase()
        {
            base.Chase();
        }

        public override void Attack()
        {
            _bulletController.SpawnBullet();
        }

        public override void Die()
        {
        }
    }
}