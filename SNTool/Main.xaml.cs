using System.Windows;
using System.Windows.Controls;

namespace SNTool
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button clickedButton = (Button)sender;
            switch (clickedButton.Content.ToString())
            {
                case "视频编辑":
                    MainFrame.Source = new Uri("./video/VideoUI.xaml", UriKind.Relative);
                    break;
                case "文件校验":
                    MainFrame.Source = new Uri("./win/FileIntegrityChecker.xaml", UriKind.Relative);
                    break;
                case "Deepseek GPT":
                    MainFrame.Source = new Uri("./chartgpt/Deepseek.xaml", UriKind.Relative);
                    break;
                // 添加更多菜单项的处理逻辑...
            }
        }
    }
}
