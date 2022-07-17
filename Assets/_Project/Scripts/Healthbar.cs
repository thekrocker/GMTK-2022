using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace DefaultNamespace
{
    public class Healthbar : MonoBehaviour
    {
        public float changeSpeed = 3f;
        public Image healthBarImage;

        [SerializeField] private Health _health;
        

        private void OnEnable()
        {
            _health.OnHealthChanged += SetHealthBar;
        }

        private void OnDisable()
        {
            _health.OnHealthChanged -= SetHealthBar;
        }

        public void SetHealthBar()
        {
            var elapsedTime = 0f;
            var totalTime = 0.4f;

            StartCoroutine(CO_SetHealth());

            IEnumerator CO_SetHealth()
            {
                while (elapsedTime < totalTime)
                {
                    elapsedTime += Time.deltaTime;
                    healthBarImage.fillAmount =
                        Mathf.Lerp(healthBarImage.fillAmount, _health.Ratio, elapsedTime / totalTime);
                    yield return null;
                }

                healthBarImage.fillAmount = _health.Ratio;
            }
        }
    }
}