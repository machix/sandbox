using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETTTimeTracker.Common;

namespace ETTTimeTracker.Models
{
    public class CopyEntry : Observable
    {
        #region IsSelected

        private bool _isSelected = true;

        /// <summary>
        /// Gets or sets the IsSelected property. This observable property 
        /// indicates whether this entry is selected.
        /// </summary>
        public bool IsSelected
        {
            get => _isSelected;
            set => Set(ref _isSelected, value);
        }

        #endregion

        #region Details

        private string _details = string.Empty;

        /// <summary>
        /// Gets or sets the Details property. This observable property 
        /// indicates the entry details.
        /// </summary>
        public string Details
        {
            get => _details;
            set => Set(ref _details, value);
        }

        #endregion

        #region LoggedTime

        private string _loggedTime = "00:00:00";

        /// <summary>
        /// Gets or sets the LoggedTime property. This observable property 
        /// indicates the logged time.
        /// </summary>
        public string LoggedTime
        {
            get => _loggedTime;
            set => Set(ref _loggedTime, value);
        }

        #endregion

        public CopyEntry(string details)
        {
            Details = details;
        }
    }
}
