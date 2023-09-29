using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;
using TestAPI_Web.Models;

namespace TestAPI_Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Privacy(double money, double percent, int month)
        {
            string requestURL_str = $"https://localhost:7184/WeatherForecast/get-double-profit?a={money}&b={percent}&c={month}";
            string responseURL_str = $"";
            // Tạo ra 1 httpClient 
            using (HttpClient client = new HttpClient())
            {
                var res = client.GetAsync(requestURL_str).Result;
                string data = res.Content.ReadAsStringAsync().Result;
                var jsondata = JsonConvert.SerializeObject(data);
                responseURL_str = JsonConvert.DeserializeObject<string>(jsondata) ?? "";
            }
            ViewData["result"] = responseURL_str;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}