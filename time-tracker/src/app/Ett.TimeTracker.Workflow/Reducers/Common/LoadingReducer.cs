namespace Ett.TimeTracker.Workflow.Reducers.Common
{
    using Ett.TimeTracker.Workflow.Actions.Common;
    using Ett.TimeTracker.Workflow.States.Common;

    using Redux;

    internal static class LoadingReducer
    {
        public static LoadingState Reduce(LoadingState state, IAction action)
        {
            if (action is LoadingStartAction)
            {
                return new LoadingState
                {
                    IsLoading = true
                };
            }

            if (action is LoadingEndAction)
            {
                return new LoadingState
                {
                    IsLoading = false
                };
            }

            return state;
        }
    }
}