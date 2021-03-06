using System;
using UnityEngine;
using UnityEngine.Events;

namespace _Project.Scripts
{
    public class ProjectileDamager : MonoBehaviour
    {
        [SerializeField] private BaseStats damage;

        public UnityEvent OnHit;

        private void OnTriggerEnter(Collider other)
        {
            var idamageable = other.GetComponent<IDamageable>();

            if (idamageable != null)
            {
                idamageable.DecreaseHealth(damage.damage);
                ParticleManager.Instance.PlayBulletHitParticle(transform);
                OnHit?.Invoke();
            }
        }
        
    }
}