using Newtonsoft.Json;

namespace TestAPI_WDF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();



        }


        /*
         * using Newtonsoft.Json;

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
         * */
        private void btn_tinhtoan_Click(object sender, EventArgs e)
        {
            double money = Convert.ToDouble(tb_money.Text);
            double percent = Convert.ToDouble(tb_percent.Text);
            int month = Convert.ToInt32(tb_month.Text);

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

            lb_profit.Text = $"Số tiền lãi bạn phải trả lả: {responseURL_str}";
        }
    }
}