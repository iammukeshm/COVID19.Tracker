using COVID19.Tracker.Core.Models.COVIDStats;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace COVID19.Tracker.Core.Services
{
    public interface IStatsService
    {
        public Task<Stats> GetStatsAsync(string code);
        public Task<Stats> GetStatsByDateAsync(string code, DateTime dateTime);
    }
}
