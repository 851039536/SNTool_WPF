using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using MChatGpt;
using Newtonsoft.Json.Linq;

namespace SNTool.chartgpt
{
    /// <summary>
    /// Deepseek.xaml 的交互逻辑
    /// </summary>
    public partial class Deepseek : Page
    {
        public Deepseek()
        {
            InitializeComponent();

            MDeepseekHelper.Keys = "sk-5a1a96d0b24a4a2ab23414895fabfd17";
            MDeepseekHelper.Model = "deepseek-chat";
            Paragraph paragraph = new Paragraph();

            paragraph.Inlines.Add(@"连续对话已开启。输入'exit'退出，输入'new'开启新会话。");
            richTextBox.Document.Blocks.Add(paragraph);
        }

        private async void SendText(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                string userInput = sendText.Text;
                if (userInput?.ToLower() == "exit") { }

                if (userInput?.ToLower() == "new")
                {
                    // 清空对话历史
                    MDeepseekHelper.conversationHistory.Clear();
                    Paragraph paragraph2 = new Paragraph();
                    paragraph2.Inlines.Add(@"新会话已开启。");
                    richTextBox.Document.Blocks.Add(paragraph2);
                }

                // 将用户的输入添加到对话历史中
                MDeepseekHelper.conversationHistory.Add(new JObject { ["content"] = userInput, ["role"] = "user" });

                // 发送请求并立即处理响应
                await MDeepseekHelper.SendMessageAndUpdateHistoryAsync();

                Paragraph paragraph3 = new Paragraph();
                paragraph3.Inlines.Add(MDeepseekHelper.Content.ToString());
                richTextBox.Document.Blocks.Add(paragraph3);
            }
        }
    }
}
