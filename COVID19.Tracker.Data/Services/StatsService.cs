using COVID19.Tracker.Core.Models.COVIDStats;
using COVID19.Tracker.Core.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace COVID19.Tracker.Data.Services
{
    public class StatsService : IStatsService
    {
        public async Task<Stats> GetStatsAsync(string code)
        {
            var apiResult = new Dictionary<string, Stats>();
            var API_URL = Data.Constants.API.BaseURL;
            using (var client = new HttpClient())
            {
                string url = $"{API_URL}data.min.json";
                var response = client.GetAsync(url).Result;
                string responseAsString = await response.Content.ReadAsStringAsync();
                apiResult = JsonConvert.DeserializeObject<Dictionary<string, Stats>>(responseAsString);
            }
            var data = apiResult.Where(a=>a.Key == code).FirstOrDefault().Value;
            return data;
        }
        public async Task<Stats> GetStatsByDateAsync(string code, DateTime dateTime)
        {
            var apiResult = new Dictionary<string, Stats>();
            var API_URL = Data.Constants.API.BaseURL;
            using (var client = new HttpClient())
            {
                var dateTimeString = dateTime.ToString("yyyy-MM-dd");
                string url = $"{API_URL}data-{dateTimeString}.min.json";
                var response = client.GetAsync(url).Result;
                string responseAsString = await response.Content.ReadAsStringAsync();
                apiResult = JsonConvert.DeserializeObject<Dictionary<string, Stats>>(responseAsString);
            }
            var data = apiResult.Where(a => a.Key == code).FirstOrDefault().Value;
            return data;
        }
    }
}
