// See https://aka.ms/new-console-template for more information

using Newtonsoft.Json;

Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.Write("Nhập tiền gốc: ");
double money = Convert.ToDouble(Console.ReadLine());
Console.Write("Nhập tỉ lễ lãi: ");
double percent = Convert.ToDouble(Console.ReadLine());
Console.Write("Nhập số tháng: ");
int month = Convert.ToInt32(Console.ReadLine());

// Tạo request URL
string requestURL_str = $"https://localhost:7184/WeatherForecast/get-double-profit?a={money}&b={percent}&c={month}";
string responseURL_str = $"";
// Tạo ra 1 httpClient 
using(HttpClient client = new HttpClient())
{
    var res = client.GetAsync(requestURL_str).Result;   
    string data = res.Content.ReadAsStringAsync().Result;
    var jsondata = JsonConvert.SerializeObject(data);
    responseURL_str = JsonConvert.DeserializeObject<string>(jsondata)??"";
}
Console.Write("Số tiền lãi bạn phải trả lả: ");
Console.WriteLine($"{responseURL_str}");
Console.ReadLine();


