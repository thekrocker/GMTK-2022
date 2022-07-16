namespace _Project.Scripts.States
{
    public abstract class BaseState<T> where T : EnemyStateMachine
    {
        protected T Sm;
        private string _stateName;

        protected BaseState(T sm, string name)
        {
            Sm = sm;
            _stateName = name;
        }

        public abstract void Enter();
        public abstract void Update();
        public abstract void Exit();
    }
}