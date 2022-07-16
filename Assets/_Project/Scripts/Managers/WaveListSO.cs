using UnityEngine;

namespace _Project.Scripts.Managers
{
    [CreateAssetMenu(menuName = "Waves/Wave List", order = 0)]
    public class WaveListSO : ScriptableObject
    {
        public WaveDataSO[] waves;
    }
}