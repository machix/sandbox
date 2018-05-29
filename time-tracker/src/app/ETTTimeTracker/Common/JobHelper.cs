using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETTTimeTracker.Models;

namespace ETTTimeTracker.Common
{
    public static class JobHelper
    {
        public static ObservableCollection<JobTitle> JobTitles { get; }

        static JobHelper()
        {
            JobTitles = new ObservableCollection<JobTitle>
            {
                new JobTitle("Regular",                   "AFE001234"  ,"AFE0001234"),
                new JobTitle("Paid Time Off",             "AFE001235"  ,"CostCenter CC001235"),
                new JobTitle("Holiday",                   "AFE001236"  ,"CostCenter CC001236"),
                new JobTitle("Jury Duty",                 "AFE001237"  ,"CostCenter CC001237"),
                new JobTitle("Bereavement",               "AFE001238"  ,"CostCenter CC001238"),
                new JobTitle("Jury Duty",                 "AFE001239"  ,"CostCenter CC001239"),
                new JobTitle("Extended Sick Leave @ 100%","AFE001241"  ,"CostCenter CC001241"),
                new JobTitle("LWOP",                      "AFE001242"  ,"CostCenter CC001242"),
                new JobTitle("Military Leave",            "AFE001243"  ,"CostCenter CC001243"),
                new JobTitle("Military Training",         "AFE001244"  ,"CostCenter CC001244"),
                new JobTitle("Office Closing",            "AFE001245"  ,"CostCenter CC001245"),
                new JobTitle("PTO Relocation Co Sponsor", "AFE001246"  ,"CostCenter CC001246"),
                new JobTitle("STD @ 66.67%",              "AFE001247"  ,"CostCenter CC001247"),
                new JobTitle("Tribe Resv Time Memo Only", "AFE001248"  ,"CostCenter CC001248"),
                new JobTitle("Workers' Compensation",     "AFE001249"  ,"CostCenter CC001249")
            };

            CopyEntries = new ObservableCollection<CopyEntry>
            {
                new CopyEntry("Storyboard Sketching - Project ETT Time Tracker"),
                new CopyEntry("Lorem ipsum dolor sit amet, consectetur adipiscing elit - Project Kiosk"),
                new CopyEntry("Lorem ipsum dolor sit amet, consectetur adipiscing elit - Project ETT Time Tracker"),
                new CopyEntry("Storyboard Sketching - Project ETT Time Tracker"),
                new CopyEntry("Lorem ipsum dolor sit amet, consectetur adipiscing elit - Project Kiosk"),
                new CopyEntry("Lorem ipsum dolor sit amet, consectetur adipiscing elit - Project ETT Time Tracker"),
                new CopyEntry("Storyboard Sketching - Project ETT Time Tracker"),
                new CopyEntry("Lorem ipsum dolor sit amet, consectetur adipiscing elit - Project Kiosk"),
                new CopyEntry("Lorem ipsum dolor sit amet, consectetur adipiscing elit - Project ETT Time Tracker"),
                new CopyEntry("Storyboard Sketching - Project ETT Time Tracker"),
                new CopyEntry("Lorem ipsum dolor sit amet, consectetur adipiscing elit - Project Kiosk"),
                new CopyEntry("Lorem ipsum dolor sit amet, consectetur adipiscing elit - Project ETT Time Tracker"),
                new CopyEntry("Storyboard Sketching - Project ETT Time Tracker"),
                new CopyEntry("Lorem ipsum dolor sit amet, consectetur adipiscing elit - Project Kiosk"),
                new CopyEntry("Lorem ipsum dolor sit amet, consectetur adipiscing elit - Project ETT Time Tracker"),
                new CopyEntry("Storyboard Sketching - Project ETT Time Tracker"),
                new CopyEntry("Lorem ipsum dolor sit amet, consectetur adipiscing elit - Project Kiosk"),
                new CopyEntry("Lorem ipsum dolor sit amet, consectetur adipiscing elit - Project ETT Time Tracker"),
                new CopyEntry("Storyboard Sketching - Project ETT Time Tracker"),
                new CopyEntry("Lorem ipsum dolor sit amet, consectetur adipiscing elit - Project Kiosk"),
                new CopyEntry("Lorem ipsum dolor sit amet, consectetur adipiscing elit - Project ETT Time Tracker"),
                new CopyEntry("Storyboard Sketching - Project ETT Time Tracker"),
                new CopyEntry("Lorem ipsum dolor sit amet, consectetur adipiscing elit - Project Kiosk"),
                new CopyEntry("Lorem ipsum dolor sit amet, consectetur adipiscing elit - Project ETT Time Tracker"),
                new CopyEntry("Storyboard Sketching - Project ETT Time Tracker"),
                new CopyEntry("Lorem ipsum dolor sit amet, consectetur adipiscing elit - Project Kiosk"),
                new CopyEntry("Lorem ipsum dolor sit amet, consectetur adipiscing elit - Project ETT Time Tracker"),
                new CopyEntry("Storyboard Sketching - Project ETT Time Tracker"),
                new CopyEntry("Lorem ipsum dolor sit amet, consectetur adipiscing elit - Project Kiosk"),
                new CopyEntry("Lorem ipsum dolor sit amet, consectetur adipiscing elit - Project ETT Time Tracker"),
            };
        }

        public static ObservableCollection<CopyEntry> CopyEntries { get; }
    }
}
