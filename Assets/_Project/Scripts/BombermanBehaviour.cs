namespace _Project.Scripts
{
    public class BombermanBehaviour : EnemyBehaviours
    {
        public override void Chase()
        {
            base.Chase();
        }

        public override void Attack()
        {
            GetComponent<EnemyMeleeDamager>().Damage();
            Die();
        }

        public override void Die()
        {
            gameObject.SetActive(false);
        }

        public override void OnDisable()
        {
            base.OnDisable();
            
            ParticleManager.Instance.PlayHasbullahParticle(transform);
        }
    }
}