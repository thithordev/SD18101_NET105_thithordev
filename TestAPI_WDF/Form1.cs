using Newtonsoft.Json;

namespace TestAPI_WDF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void btn_Calculate_Click(object sender, EventArgs e)
        {
            double money = Convert.ToDouble(tbt_Money.Text);
            double percent = Convert.ToDouble(tbt_Percent.Text);
            int month = Convert.ToInt32(tbt_Month.Text);
            string requestURL = $"https://localhost:7184/WeatherForecast/" +
    $"get-double-profit?a={money}&b={percent}&c={month}";
            var HttpClient = new HttpClient(); // Tạo ra 1 httpClient 
            var response = HttpClient.GetAsync(requestURL).Result; // Đọc responseBody từ URL
            string apiData = await response.Content.ReadAsStringAsync();
            // Lấy dữ liệu lấy được chuyển sang dạng string
            // Lấy kết quả vừa thu được ép kiểu sang kiểu dữ liệu mình cần
            var result = JsonConvert.DeserializeObject<int>(apiData);
            lb_Result.Text = "Bạn vừa thực hiện 1 lệnh báo nhà là " + result;
        }
    }
}