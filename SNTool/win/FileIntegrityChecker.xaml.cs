using MewTool.EncryptionCategory;
using MewTool.FormCategory;
using System.Windows;
using System.Windows.Controls;

namespace SNTool.win
{
    /// <summary>
    /// Page2.xaml 的交互逻辑
    /// </summary>
    public partial class FileIntegrityChecker : Page
    {
        public FileIntegrityChecker()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string ret = MSecurityHelper.CalculateMd5Hash(TFile2.Text);
            TFileMd55.Text = ret;
            _ = MessageBox.Show("MD5值：" + ret);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            TFile2.Text = MFormHelper.ShowDialog("文件选择", true);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            TFile.Text = MFormHelper.ShowDialog("文件选择", true);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            bool ret = MSecurityHelper.VerifyFileIntegrity(TFile.Text, TFileMd5.Text);
            _ = MessageBox.Show("校验结果：" + ret);
        }
    }
}
