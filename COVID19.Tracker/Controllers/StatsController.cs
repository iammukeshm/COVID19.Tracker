using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using COVID19.Tracker.Core.Models.COVIDStats;
using COVID19.Tracker.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace COVID19.Tracker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatsController : ControllerBase
    {
        private readonly IStatsService statsService;

        public StatsController(IStatsService statsService)
        {
            this.statsService = statsService;
        }
        public async Task<IActionResult> GetStatsByDateAsync([FromQuery] string code, [FromQuery] DateTime date)
        {
            var data = new Stats();
            if (date < DateTime.Now)
            {
                var baseDate = new DateTime(2020, 1, 1);
                if (baseDate > date || date == DateTime.Today)
                {
                    data = await statsService.GetStatsAsync(code);
                }
                else
                {
                    data = await statsService.GetStatsByDateAsync(code, date);
                }
            }
            return Ok(data);
        }
    }
}