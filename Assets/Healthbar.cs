using System;
using UnityEngine;
using UnityEngine.UI;

namespace DefaultNamespace
{
    [RequireComponent(typeof(Health))]
    public class Healthbar : MonoBehaviour
    {
        public float changeSpeed = 3f;
        public Image healthBarImage;
        
        private Health _health;

        private void Awake()
        {
            _health = GetComponent<Health>();
        }

        private void Update()
        {
            SetHealthBar();
        }

        public void SetHealthBar()
        {
            healthBarImage.fillAmount = Mathf.Lerp(healthBarImage.fillAmount, _health.Ratio, Time.deltaTime * changeSpeed);
        }
    }
}