using System;
using System.Collections;
using _Project.Scriptable_Objects.Scripts;
using UnityEngine;

namespace _Project.Scripts
{
    public class PlayerBullet : BaseBullet
    {
        [SerializeField] private PlayerStats stats;

        public override void Fire(Vector3 point)
        {
            _rb.AddForce(point * stats.bulletSpeed, ForceMode.Impulse);
        }
    }
}