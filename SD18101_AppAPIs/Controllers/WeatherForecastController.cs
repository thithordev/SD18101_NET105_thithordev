using Microsoft.AspNetCore.Mvc;

namespace SD18101_AppAPIs.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 10).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)],
                Status = "Xin chao"
            })
            .ToArray();
        }
        [HttpGet("get-age-from-dob")]
        public string GetAgeFromDob(int dob)
        {
            var age = DateTime.Now.Year - dob; // DateTime.Now.Year lấy năm hiện tại
            return $"Tuổi của người sinh năm {dob} là {age}";
        }
        // Viết API trả về chỉ số BMI của Bạn với côn thức sau
        // BMI = nặng / (cao * cao) ( nặng: kg, cao: m)
        [HttpGet("get-bmi")]
        public double GetBMI(double cao, double nang)
        {
            return nang / (cao * cao);
        }
        [HttpGet]
        [Route("loi-chao")]
        public string GetLoiChao()
        {
            string[] loichaos = { "Hello", "Goodbye", "Good Morning" };
            Random r = new Random();
            return loichaos[r.Next(loichaos.Length)];
            // r.Next(loichaos.Length) = random 1 số từ 0 đến Length
        }
        // Viết API tính lãi kép theo công thức sau:
        // Lãi = số tiền cuối cùng - số tiền gốc
        // số tiền gốc = a, tỉ lệ lãi là b, số tháng là c thì
        // tiền lãi = a * (1+b/100)^c - a
        [HttpGet]
        [Route("get-double-profit")]
        public int GetProfit(double a, double b, int c)
        {
            if (a <= 0 || c <= 0 || b <= 0)
            {
                return 0;
            }
            else
            {
                var profit = a * Math.Pow((1 + b / 100), c * 1.0) - a;
                return (int)profit;
            }
        }
        // Link request URL sẽ có dạng:
        // https://localhost:7184/WeatherForecast/get-double-profit?a=1000000&b=50&c=2
        // ? đánh dấu bắt đầu có giá trị cho các tham số, mỗi giá trị sẽ cách nhau 1 dấu & 
    }
}