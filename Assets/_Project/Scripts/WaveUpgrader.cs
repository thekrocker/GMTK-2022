namespace _Project.Scripts
{
    public class WaveUpgrader : BaseUpgrader
    {
        public override void Upgrade()
        {
            WaveManager.Instance.GetNextWave().amount = targetAmount;
        }
    }
}