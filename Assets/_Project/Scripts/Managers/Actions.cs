using System;

namespace _Project.Scripts.Managers
{
    public static class Actions
    {
        public static Action OnWaveEnd;
        public static Action<int> OnDiceRoll;
        public static Action OnUpgraded;
        
        public static Action OnUpgradeHealth; // Bunun gibi upgrade değişkenleri oluşturalım.
        public static Action OnUpgradeDamage;
        public static Action OnUpgradeMovementSpeed;
        public static Action OnUpgradeWaveCount;
        
        
    }
}