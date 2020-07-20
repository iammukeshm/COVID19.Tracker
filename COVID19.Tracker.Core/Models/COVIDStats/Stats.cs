using System;
using System.Collections.Generic;
using System.Text;

namespace COVID19.Tracker.Core.Models.COVIDStats
{
    public class Stats
    {
        public Delta Delta { get; set; }
        public Meta Meta { get; set; }
        public Total Total { get; set; }
        public Dictionary<string, Stats> Districts { get; set; }
    }
}
