using System;
using System.Collections.Generic;
using System.Text;

namespace COVID19.Tracker.Core.Models.COVIDStats
{
    public class Total
    {
        public int Confirmed { get; set; }
        public int Deceased { get; set; }
        public int Migrated { get; set; }
        public int Recovered { get; set; }
        public int Tested { get; set; }

    }
}
