using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;
using TestAPI_WEB.Models;

namespace TestAPI_WEB.Controllers
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
            string requestURL = $"https://localhost:7184/WeatherForecast/" +
    $"get-double-profit?b={percent}&c={month}&a={money}";
            var HttpClient = new HttpClient(); // Tạo ra 1 httpClient 
            var response = HttpClient.GetAsync(requestURL).Result; // Đọc responseBody từ URL
            string apiData = await response.Content.ReadAsStringAsync();
            // Lấy dữ liệu lấy được chuyển sang dạng string
            // Lấy kết quả vừa thu được ép kiểu sang kiểu dữ liệu mình cần
            var result = JsonConvert.DeserializeObject<int>(apiData);
            ViewData["result"] = result;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}