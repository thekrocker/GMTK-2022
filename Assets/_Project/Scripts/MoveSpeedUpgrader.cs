namespace _Project.Scripts
{
    public class MoveSpeedUpgrader : BaseUpgrader
    {
        public override void Upgrade()
        {
            foreach (var stat in stats)
            {
                stat.speed = targetAmount;
            }
        }
    }
}