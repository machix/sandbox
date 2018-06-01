namespace ETTTimeTracker.Connectors.Dashboard
{
    using ETTTimeTracker.ViewModels;

    internal sealed class DashboardConnector
    {
        private readonly ETTViewModel ett;

        private readonly SettingsViewModel settings;

        public DashboardConnector(
            ETTViewModel ett, 
            SettingsViewModel settings)
        {
            this.ett = ett;
            this.settings = settings;
        }
    }
}