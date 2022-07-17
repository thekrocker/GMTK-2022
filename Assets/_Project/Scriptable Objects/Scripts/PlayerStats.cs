using _Project.Scripts;
using Sirenix.OdinInspector;
using UnityEngine;

namespace _Project.Scriptable_Objects.Scripts
{
    [CreateAssetMenu(menuName = "Stats/PlayerStats", order = 0)]
    public class PlayerStats : BaseStats
    {
        [Title("Movement")]
        public float moveSpeed;

        [Title("Attack Properties")] 
        public float bulletSpeed;
        public float attackInterval;

    }
}