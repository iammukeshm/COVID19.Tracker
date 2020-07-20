using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using COVID19.Tracker.Core.Models.COVIDStats;
using COVID19.Tracker.Core.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace COVID19.Tracker.Pages
{
    public class IndexModel : PageModel
    {
        public IndexModel(IStatsService service, ILogger<IndexModel> logger)
        {
            this._service = service;
            _logger = logger;
        }
        private readonly ILogger<IndexModel> _logger;
        private readonly IStatsService _service;
        public DashboardViewModel ViewModel { get; set; }
        public class DashboardViewModel
        {
            public Stats Stats { get; set; }
        }

        public async Task OnGet()
        {
            this.ViewModel = new DashboardViewModel();
            ViewModel.Stats = await _service.GetStatsAsync("TN");
        }
    }
}
