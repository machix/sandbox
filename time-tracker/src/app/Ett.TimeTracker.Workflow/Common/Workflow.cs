namespace Ett.TimeTracker.Workflow.Common
{
    using AutoMapper;

    using Ett.TimeTracker.Workflow.Infrastructure;
    using Ett.TimeTracker.Workflow.Reducers.Common;
    using Ett.TimeTracker.Workflow.States.Common;

    using Redux;

    public sealed class Workflow
    {
        public readonly IStore<WorkflowState> Store = new Store<WorkflowState>(
            WorkflowReducer.Reduce, new WorkflowState());

        public Workflow(params Profile[] profiles)
        {
            DependencyInjectionUtils.Initialize(profiles);
        }
    }
}