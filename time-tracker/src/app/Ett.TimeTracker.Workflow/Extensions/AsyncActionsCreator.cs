namespace Ett.TimeTracker.Workflow.Extensions
{
    using System;
    using System.Threading.Tasks;

    using Redux;

    public delegate Task AsyncActionsCreator<in TState>(Dispatcher dispatcher, Func<TState> getState);
}