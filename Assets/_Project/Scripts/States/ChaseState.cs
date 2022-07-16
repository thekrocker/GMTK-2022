using UnityEngine;

namespace _Project.Scripts.States
{
    public class ChaseState : BaseState<EnemyStateMachine>
    {
        public ChaseState(EnemyStateMachine sm) : base(sm, "Chase State")
        {
        }

        public override void Enter()
        {
            Debug.Log("Chasing..");
            
            Sm.EnemyBehaviours.StopAgent(false);
        }

        public override void Update()
        {
            Sm.EnemyBehaviours.Chase();
            if (Sm.EnemyBehaviours.IsInAttackRange()) Sm.ChangeState(Sm.EnemyAttackState);
        }

        public override void Exit()
        {
            Sm.EnemyBehaviours.StopAgent(true);
        }
    }
}