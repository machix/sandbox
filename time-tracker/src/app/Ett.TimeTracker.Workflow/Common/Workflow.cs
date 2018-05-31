namespace Ett.TimeTracker.Workflow.Common
{
    using Ett.TimeTracker.Workflow.Infrastructure;
    using Ett.TimeTracker.Workflow.Reducers.Common;
    using Ett.TimeTracker.Workflow.States.Common;

    using Redux;

    public sealed class Workflow
    {
        private static Workflow instance;
        private static readonly object Padlock = new object();

        private Workflow()
        {
            DependencyInjectionUtils.Initialize();
        }

        public readonly IStore<WorkflowState> Store = new Store<WorkflowState>(
            WorkflowReducer.Reduce, new WorkflowState());

        public static Workflow Instance
        {
            get
            {
                lock (Padlock)
                {
                    if (instance == null)
                    {
                        instance = new Workflow();

                    }

                    return instance;
                }
            }
        }
    }
}