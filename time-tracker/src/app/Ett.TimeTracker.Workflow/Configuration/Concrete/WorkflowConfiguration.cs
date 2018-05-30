namespace Ett.TimeTracker.Workflow.Configuration.Concrete
{
    using System.Configuration;

    internal class WorkflowConfiguration : IWorkflowConfiguration
    {
        private string connectionString;

        public string ConnectionString => this.connectionString ?? (this.connectionString = ConfigurationManager.ConnectionStrings["TimeTrackerSqlServerDbContext"].ConnectionString);
    }
}