using COVID19.Tracker.Core.Services;
using COVID19.Tracker.Data.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace COVID19.Tracker.Data
{
    public static class ServiceRegistration
    {
        public static void AddDataLayer(this IServiceCollection services, IConfiguration configuration)
        {

            #region Services
            services.AddTransient<IStateService, StateService>();
            services.AddTransient<IStatsService, StatsService>();
            #endregion


        }
    }
}
