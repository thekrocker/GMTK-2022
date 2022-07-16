using System;
using _Project.Scriptable_Objects.Scripts;
using UnityEngine;

namespace _Project.Scripts
{
    public class Bullet : MonoBehaviour
    {
        [SerializeField] private PlayerStats stats;
        
        [SerializeField] private float destroyTime;

        private Rigidbody _rb;

        private void Awake()
        {
            _rb = GetComponent<Rigidbody>();
        }
        
        public void InvokePush()
        {
            Invoke(nameof(Push), destroyTime);
        }
        
        
        public void ResetVelocity()
        {
            _rb.velocity = Vector3.zero;
        }

        public void Fire(Vector3 point)
        {
            _rb.AddForce(point * stats.bulletSpeed, ForceMode.Impulse);
        }

        private void Push()
        {
            gameObject.SetActive(false);
        }
    }
}