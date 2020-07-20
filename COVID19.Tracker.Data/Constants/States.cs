using COVID19.Tracker.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace COVID19.Tracker.Data.Constants
{
    public static class States
    {
        public static List<State> Data => new List<State>()
        {
            new State{ Code="AP", Name = "Andhra Pradesh" },
            new State{ Code="AR", Name = "Arunachal Pradesh" },
            new State{ Code="AS", Name = "Assam" },
            new State{ Code="BR", Name = "Bihar" },
            new State{ Code="CT", Name = "Chhattisgarh" },
            new State{ Code="GA", Name = "Goa" },
            new State{ Code="GJ", Name = "Gujarat" },
            new State{ Code="HR", Name = "Haryana" },
            new State{ Code="HP", Name = "Himachal Pradesh" },
            new State{ Code="JH", Name = "Jharkhand" },
            new State{ Code="KA", Name = "Karnataka" },
            new State{ Code="KL", Name = "Kerala" },
            new State{ Code="MP", Name = "Madhya Pradesh" },
            new State{ Code="MH", Name = "Maharashtra" },
            new State{ Code="MN", Name = "Manipur" },
            new State{ Code="ML", Name = "Meghalaya" },
            new State{ Code="MZ", Name = "Mizoram" },
            new State{ Code="NL", Name = "Nagaland" },
            new State{ Code="OR", Name = "Odisha" },
            new State{ Code="PB", Name = "Punjab" },
            new State{ Code="RJ", Name = "Rajasthan" },
            new State{ Code="SK", Name = "Sikkim" },
            new State{ Code="TN", Name = "Tamil Nadu" },
            new State{ Code="TG", Name = "Telangana" },
            new State{ Code="TR", Name = "Tripura" },
            new State{ Code="UT", Name = "Uttarakhand" },
            new State{ Code="UP", Name = "Uttar Pradesh" },
            new State{ Code="WB", Name = "West Bengal" },
            new State{ Code="AN", Name = "Andaman and Nicobar Islands" },
            new State{ Code="CH", Name = "Chandigarh" },
            new State{ Code="DN", Name = "Dadra and Nagar Haveli and Daman and Diu" },
            new State{ Code="DL", Name = "Delhi" },
            new State{ Code="JK", Name = "Jammu and Kashmir" },
            new State{ Code="LA", Name = "Ladakh" },
            new State{ Code="LD", Name = "Lakshadweep" },
            new State{ Code="PY", Name = "Puducherry" },
            new State{ Code="TT", Name = "India" },
        };
    }
}
