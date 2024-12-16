
namespace Telegram_Notify_API_Test
{
    public partial class Form1 : Form
    {
        // 請替換成你的 Channel Access Token
        private const string ChannelAccessToken = "BOT_TOKEN";
        // 請替換成你的目標群組 ID
        private const string GroupId = "GROUPID";
        // 請替換成你的目標人員 ID
        //private const string UserId = "PRIVATEID";
        // 構建 Telegram API 請求 URL
        string url = $"https://api.telegram.org/bot{ChannelAccessToken}/sendMessage";
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                await SendTelegram();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async Task SendTelegram()
        {
            // 使用 HttpClient 發送 POST 請求
            using (HttpClient client = new HttpClient())
            {
                var formData = new MultipartFormDataContent();
                formData?.Add(new StringContent(GroupId), "chat_id");
                formData?.Add(new StringContent(textBox1.Text), "text");

                // 發送 POST 請求
                HttpResponseMessage response = await client.PostAsync(url, formData);

                // 檢查回應狀態碼
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show($"訊息已成功發送！狀態碼: {response.StatusCode}");
                }
                else
                {
                    MessageBox.Show($"發送失敗，狀態碼: {response.StatusCode}");
                }
            }
        }
    }
}
