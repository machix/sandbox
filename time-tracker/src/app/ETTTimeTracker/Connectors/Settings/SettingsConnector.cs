namespace ETTTimeTracker.Connectors.Settings
{
    using ETTTimeTracker.ViewModels;

    internal sealed class SettingsConnector
    {
        private readonly ETTViewModel ett;

        private readonly SettingsViewModel settings;

        public SettingsConnector(
            ETTViewModel ett, 
            SettingsViewModel settings)
        {
            this.ett = ett;
            this.settings = settings;
        }
    }
}