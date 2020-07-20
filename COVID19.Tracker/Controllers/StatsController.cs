using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        public async Task<IActionResult> Get([FromQuery] string code)
        {
            
            var data = await statsService.GetStatsAsync(code);
            return Ok(data);
        }
    }
}