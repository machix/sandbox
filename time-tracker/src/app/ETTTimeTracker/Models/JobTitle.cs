using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETTTimeTracker.Models
{
    public class JobTitle 
    {
        public string Name { get; set; }
        public string AFE { get; set; }
        public string CostCenter { get; set; }
        public JobTitle(string name, string afe, string costCenter)
        {
            Name = name;
            AFE = afe;
            CostCenter = costCenter;
        }
    }
}
