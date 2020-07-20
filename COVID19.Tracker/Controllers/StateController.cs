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
    public class StateController : ControllerBase
    {
        private readonly IStateService stateService;

        public StateController(IStateService stateService)
        {
            this.stateService = stateService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var states = stateService.GetAllStates();
            return Ok(states);
        }
        [HttpGet]
        [Route("search")]
        public async Task<IActionResult> Search(string term)
        {
            var states= stateService.GetAllStates();
            states.RemoveAll(a => a.Code == "TT");
            var data = states.Where(a => a.Code.Contains(term,StringComparison.OrdinalIgnoreCase) || a.Name.Contains(term, StringComparison.OrdinalIgnoreCase)).ToList().AsReadOnly();
            return Ok(data);
        }
    }
}