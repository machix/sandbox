using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETTTimeTracker.Models
{
    public class JobTaskBackup
    {
        public string Name { get; set; }
        public string Comments { get; set; }
        public string CostCenter { get; set; }
        public string  AFE { get; set; }
        public TimeSpan ManualStartTime { get; set; }
        public TimeSpan ManualEndTime { get; set; }
    }
}
