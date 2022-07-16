using UnityEngine;

namespace _Project.Scripts
{
    public class DestructibleObject : MonoBehaviour
    {
        public void Disable()
        {
            gameObject.SetActive(false);
        }
    }
}