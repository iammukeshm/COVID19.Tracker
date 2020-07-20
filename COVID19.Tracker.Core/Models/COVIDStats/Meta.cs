using System;
using System.Collections.Generic;
using System.Text;

namespace COVID19.Tracker.Core.Models.COVIDStats
{
    public class Meta
    {
        public DateTime Last_Updated { get; set; }
        public int Population { get; set; }
        public Tested Tested { get; set; }

    }
}
