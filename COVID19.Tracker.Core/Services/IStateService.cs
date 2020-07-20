using COVID19.Tracker.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace COVID19.Tracker.Core.Services
{
    public interface IStateService
    {
        public List<State> GetAllStates();
    }
}
