using COVID19.Tracker.Core.Models;
using COVID19.Tracker.Core.Services;
using COVID19.Tracker.Data.Constants;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace COVID19.Tracker.Data.Services
{
    public class StateService : IStateService
    {
        public List<State> GetAllStates()
        {
            var allStates = States.Data;
            return allStates;
        }
    }
}
