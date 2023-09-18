// Vì Response Body sẽ ở dạng json nên khi thực hiện
// lấy giá trị ta phải xử lý được chuỗi json
using Newtonsoft.Json;
Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("Nhập tiền gốc");
double money = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Nhập tỉ lệ lãi");
double percent = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Nhập số tháng");
int month = Convert.ToInt32(Console.ReadLine());
// Tạo request URL:
string requestURL = $"https://localhost:7184/WeatherForecast/" +
    $"get-double-profit?a={money}&b={percent}&c={month}";
var HttpClient = new HttpClient(); // Tạo ra 1 httpClient 
var response = HttpClient.GetAsync(requestURL).Result; // Đọc responseBody từ URL
string apiData = await response.Content.ReadAsStringAsync(); 
// Lấy dữ liệu lấy được chuyển sang dạng string
// Lấy kết quả vừa thu được ép kiểu sang kiểu dữ liệu mình cần
var result = JsonConvert.DeserializeObject<int>(apiData);
    Console.WriteLine("Số lãi bạn phải trả: "+ result);
Console.ReadKey();
