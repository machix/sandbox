namespace ETTTimeTracker.Connectors.Reports
{
    using ETTTimeTracker.ViewModels;

    internal sealed class ReportsConnector
    {
        private readonly ETTViewModel ett;

        private readonly SettingsViewModel settings;

        public ReportsConnector(
            ETTViewModel ett, 
            SettingsViewModel settings)
        {
            this.ett = ett;
            this.settings = settings;
        }
    }
}