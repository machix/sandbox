using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETTTimeTracker.Common
{
    public class SettingsEventArgs : EventArgs
    {
        public bool SaveSettings { get; private set; }

        public SettingsEventArgs(bool save = true)
        {
            SaveSettings = save;
        }
    }
}
