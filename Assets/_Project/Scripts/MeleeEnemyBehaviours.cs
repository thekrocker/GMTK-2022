using System;
using System.Collections;
using UnityEngine;

namespace _Project.Scripts
{
    public class MeleeEnemyBehaviours : EnemyBehaviours
    {
        private EnemyMeleeDamager _meleeDamager;

        public override void Chase()
        {
            base.Chase();
        }

        private void Start()
        {
            _meleeDamager = GetComponent<EnemyMeleeDamager>();
        }

        public override void Attack()
        {
            _meleeDamager.Damage();
        }

        public override void Die()
        {
            
        }
    }
}