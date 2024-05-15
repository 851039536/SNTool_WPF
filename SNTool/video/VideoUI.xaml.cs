using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;

namespace SNTool.video
{
    /// <summary>
    /// Page1.xaml 的交互逻辑
    /// </summary>
    public partial class VideoUI : Page
    {
        public VideoUI()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
        }

        System.Timers.Timer timer = null;

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            //子线程执行
            this.Dispatcher.Invoke(
                new Action(() =>
                {
                    //主线程
                    posSlider.Value = me.Position.TotalSeconds;
                    SetTime();
                })
            );
        }

        /// <summary>
        /// 设置时间文本框的值
        /// </summary>
        private void SetTime()
        {
            lblTime.Content = string.Format(
                "{0:00}:{1:00}:{2:00}",
                me.Position.Hours,
                me.Position.Minutes,
                me.Position.Seconds
            );
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed;
        }

        //选择播放文件
        private void OpenBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter =
                @"视频文件(*.avi格式)|*.avi|视频文件(*.wav格式)|*.wav|视频文件(*.wmv格式)|*.wmv|视频文件(*.mp4格式)|*.mp4|All Files|*.*";
            if (ofd.ShowDialog() == false)
            {
                return;
            }
            string filePath = "";
            filePath = ofd.FileName;
            if (filePath == "")
                return;
            //设置媒体源
            me.Source = new Uri(filePath, UriKind.Absolute);
            playBtn.IsEnabled = true;
            me.Play();
            timer.Start();
            playBtn.Content = "暂停";
        }

        //播放或暂停
        private void PlayBtn_Click(object sender, RoutedEventArgs e)
        {
            SetPlayer(true);
            PlayPause();
        }

        /// <summary>
        /// 播放或暂停
        /// </summary>
        private void PlayPause()
        {
            if (playBtn.Content.ToString() == "播放")
            {
                me.Play();
                timer.Start();
                playBtn.Content = "暂停";
                me.ToolTip = "单击暂停";
            }
            else
            {
                me.Pause();
                timer.Stop();
                playBtn.Content = "播放";
                me.ToolTip = "单击播放";
                SetTime();
            }
        }

        /// <summary>
        /// 设置操作按钮的可用状态
        /// </summary>
        /// <param name="bl"></param>
        private void SetPlayer(bool bl)
        {
            stopBtn.IsEnabled = bl;
            playBtn.IsEnabled = bl;
            backBtn.IsEnabled = bl;
            forwardBtn.IsEnabled = bl;
        }

        /// <summary>
        /// 停止
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StopBtn_Click(object sender, RoutedEventArgs e)
        {
            me.Stop();
            posSlider.Value = 0;
            lblTime.Content = "0:0:0";
            playBtn.Content = "播放";
            timer.Stop();
        }

        /// <summary>
        /// 快进 当前播放位置前进10s
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ForwardBtn_Click(object sender, RoutedEventArgs e)
        {
            me.Pause();
            timer.Stop();
            me.Position = me.Position + TimeSpan.FromSeconds(5);
            SetTime();
            me.Play();
            timer.Start();
        }

        /// <summary>
        /// 快退
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            me.Pause();
            timer.Stop();
            me.Position = me.Position - TimeSpan.FromSeconds(10);
            SetTime();
            me.Play();
            timer.Start();
        }

        private void Me_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            PlayPause();
        }

        /// <summary>
        /// 媒体加载完毕后
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Me_MediaOpened(object sender, RoutedEventArgs e)
        {
            posSlider.Maximum = me.NaturalDuration.TimeSpan.TotalSeconds;
            lblTime.Content = "0:0:0";
            SetPlayer(true);
        }

        /// <summary>
        ///拖动播放进度
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PosSlider_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            me.Pause();
            timer.Stop();
            int val = (int)posSlider.Value;
            me.Position = new TimeSpan(0, 0, 0, val);
            SetTime();
            me.Play();
            timer.Start();
        }

        private void Me_MediaEnded(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("播放结束");
            timer.Stop();
        }
    }
}
