using System;
using _Project.Scriptable_Objects.Scripts;
using UnityEngine;

namespace _Project.Scripts
{
    public class Bullet : MonoBehaviour
    {
        [SerializeField] private PlayerStats stats;
        
        private Rigidbody _rb;
        
        private void Awake()
        {
            _rb = GetComponent<Rigidbody>();
        }
        
        public void Fire(Vector3 point)
        {
            _rb.AddForce(point * stats.bulletSpeed, ForceMode.Impulse);
        }
    }
}