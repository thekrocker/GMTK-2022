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
        }

        public override void Update()
        {
            
        }

        public override void Exit()
        {
            
        }
    }
}