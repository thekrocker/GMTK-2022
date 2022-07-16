using _Project.Scripts.States;
using UnityEngine;

public class EnemyStateMachine : MonoBehaviour
{
    public BaseState<EnemyStateMachine> CurrentState;
    public ChaseState EnemyChaseState;
    public AttackState EnemyAttackState;
    public DieState EnemyDieState;

    
    private void Awake()
    {
        SetStates();
    }

    private void Start()
    {
        CurrentState = GetInitialState();
        CurrentState?.Enter();
    }

    public void ChangeState(BaseState<EnemyStateMachine> nextState)
    {
        CurrentState.Exit();
        CurrentState = nextState;
        CurrentState.Enter();
    }

    private void SetStates()
    {
        EnemyChaseState = new ChaseState(this);
        EnemyAttackState = new AttackState(this);
        EnemyDieState = new DieState(this);
    }
    
    private BaseState<EnemyStateMachine> GetInitialState() => EnemyChaseState;
}