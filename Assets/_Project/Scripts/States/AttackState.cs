using UnityEngine;

namespace _Project.Scripts.States
{
    public class AttackState : BaseState<EnemyStateMachine>
    {
        public AttackState(EnemyStateMachine sm) : base(sm, "Attacking..")
        {
        }
        public override void Enter()
        {
            Sm.AnimationController.HandleAttackAnimation(true);
        }

        public override void Update()
        {
            Debug.Log("Attack!!");
            
            Sm.EnemyBehaviours.Look();

            if (!Sm.EnemyBehaviours.IsInAttackRange()) Sm.ChangeState(Sm.EnemyChaseState);
        }

        public override void Exit()
        {
            Sm.AnimationController.HandleAttackAnimation(false);
        }
    }
}