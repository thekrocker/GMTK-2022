using System.Collections;
using UnityEngine;

namespace _Project.Scripts
{
    public class BaseBullet : MonoBehaviour
    {
        [SerializeField] protected float destroyTime;

        protected Rigidbody _rb;

        private void Awake()
        {
            _rb = GetComponent<Rigidbody>();
        }

        private void OnDisable()
        {
            StopAllCoroutines();
        }

        public void InvokePush()
        {
            StartCoroutine(CO_InvokePush());

            IEnumerator CO_InvokePush()
            {
                yield return new WaitForSeconds(destroyTime);
                Push();
            }
        }

        public void ResetVelocity()
        {
            _rb.velocity = Vector3.zero;
        }

        public void Push()
        {
            gameObject.SetActive(false);
        }

        public virtual void Fire(Vector3 point)
        {
        }
    }
}