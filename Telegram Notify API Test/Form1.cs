
namespace Telegram_Notify_API_Test
{
    public partial class Form1 : Form
    {
        // �д������A�� Channel Access Token
        private const string ChannelAccessToken = "BOT_TOKEN";
        // �д������A���ؼиs�� ID
        private const string GroupId = "GROUPID";
        // �д������A���ؼФH�� ID
        //private const string UserId = "PRIVATEID";
        // �c�� Telegram API �ШD URL
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
            // �ϥ� HttpClient �o�e POST �ШD
            using (HttpClient client = new HttpClient())
            {
                var formData = new MultipartFormDataContent();
                formData?.Add(new StringContent(GroupId), "chat_id");
                formData?.Add(new StringContent(textBox1.Text), "text");

                // �o�e POST �ШD
                HttpResponseMessage response = await client.PostAsync(url, formData);

                // �ˬd�^�����A�X
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show($"�T���w���\�o�e�I���A�X: {response.StatusCode}");
                }
                else
                {
                    MessageBox.Show($"�o�e���ѡA���A�X: {response.StatusCode}");
                }
            }
        }
    }
}
