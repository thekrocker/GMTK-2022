using _Project.Scripts.States;
using UnityEngine;

public class EnemyStateMachine : MonoBehaviour
{
    public BaseState<EnemyStateMachine> CurrentState;
    public ChaseState EnemyChaseState;
    public AttackState EnemyAttackState;
    public DieState EnemyDieState;
    
    public EnemyBehaviours EnemyBehaviours { get; private set; }
    public EnemyAnimationController AnimationController { get; private set; }
    
    private void Awake()
    {
        SetStates();
        SetReferences();
    }

    private void Start()
    {
        CurrentState = GetInitialState();
        CurrentState?.Enter();
    }

    private void Update()
    {
        CurrentState?.Update();
    }

    private void SetReferences()
    {
        EnemyBehaviours = GetComponent<EnemyBehaviours>();
        AnimationController = GetComponent<EnemyAnimationController>();
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