using UnityEngine;

namespace _Project.Scripts.Managers
{
    [CreateAssetMenu(menuName = "Waves/WaveData", order = 0)]
    public class WaveDataSO : ScriptableObject
    {
        public GameObject[] enemies;
        public int amount;

    }
}