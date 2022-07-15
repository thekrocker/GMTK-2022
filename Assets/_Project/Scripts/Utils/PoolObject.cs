using System;
using UnityEngine;

namespace _Project.Scripts.Utils
{
    public class PoolObject : MonoBehaviour, IPoolable<PoolObject>
    {
        private Action<PoolObject> returnToPool;

        private void OnDisable()
        {
            Debug.Log("Disabling..");
            ReturnToPool();
        }

        public void Initialize(Action<PoolObject> returnAction) => returnToPool = returnAction;
        public void ReturnToPool() => returnToPool?.Invoke(this);
    }
}