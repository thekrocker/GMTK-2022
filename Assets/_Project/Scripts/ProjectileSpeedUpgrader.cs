using System;

namespace _Project.Scripts
{
    public class ProjectileSpeedUpgrader : BaseUpgrader
    {
        public override void Upgrade()
        {
            foreach (var stat in stats)
            {
                stat.projectileSpeed = targetAmount;
            }
        }
    }
}