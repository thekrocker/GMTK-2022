using _Project.Scripts;
using UnityEngine;

namespace DefaultNamespace
{
    public class DamageUpgrader : BaseUpgrader
    {
        
        public override void Upgrade()
        {
            foreach (var stat in stats)
            {
                stat.damage = targetAmount;
            }
        }
    }
}