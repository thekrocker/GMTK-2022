using UnityEngine;

namespace _Project.Scripts
{
    [CreateAssetMenu(menuName = "Stats/EnemyStats", order = 0)]
    public class EnemyStats : ScriptableObject
    {
        public float attackRange;
        public float speed;

        public float projectileSpeed;
    }
}