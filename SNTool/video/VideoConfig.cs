using MewTool.FileCategory;
using MewTool.GeneralCategory;
using System.IO;

namespace SNTool.video
{
    public partial class VideoUI
    {
        /// <summary>
        /// 视频地址
        /// </summary>
        public string filePath;

        public string cuPathVideo = MUtil.GetCurrentProgramDirectory();

        /// <summary>
        /// 将一个整数（代表秒数）转换为HH:mm:ss的格式
        /// </summary>
        /// <param name="totalSeconds"></param>
        /// <returns></returns>
        private static string ConvertToTimeString(int totalSeconds)
        {
            int hours = totalSeconds / 3600;
            int minutes = totalSeconds % 3600 / 60;
            int remainingSeconds = totalSeconds % 60;

            return $"{hours:D2}:{minutes:D2}:{remainingSeconds:D2}";
        }

        private void GetFolder()
        {
            // 读取文件
            string folderPath = $"{cuPathVideo}\\video\\folder";
            string[] fullFileNames = MFileHelper.GetFileNames(folderPath);

            // 使用LINQ来提取文件名和后缀名
            string[] fileNamesAndExtensions = fullFileNames
                .Select(fileName =>
                    Path.GetFileName(fileName) // 提取文件名，包括后缀名
                )
                .ToArray(); // 转换为数组

            // 将处理后的文件名和后缀名数组赋值给ListBox的ItemsSource
            myListBox.ItemsSource = fileNamesAndExtensions;
        }
    }
}
