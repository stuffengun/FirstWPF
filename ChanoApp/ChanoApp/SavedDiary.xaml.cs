using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Shapes;

namespace ChanoApp
{
    /// <summary>
    /// SavedDiary.xaml에 대한 상호 작용 논리
    /// </summary>

    public partial class SavedDiary : Window
    {
        public SavedDiary(int SelectRow)
        {
            InitializeComponent();

            string appPath = AppDomain.CurrentDomain.BaseDirectory;
            string diaryPath = System.IO.Path.Combine(appPath, "Diary"); //다이어리까지 감 


            FileSystemWatcher watcher = new FileSystemWatcher();
            watcher.Path = diaryPath;
            watcher.Filter = "*.txt";

            string[] existingFiles = Directory.GetFiles(diaryPath, watcher.Filter);
            string file = existingFiles[SelectRow];
            FileInfo fileInfo = new FileInfo(file);
            var filePath = fileInfo.FullName;
            string fileName = fileInfo.Name;
            titleText.Content = fileName;
               
            var lines = File.ReadLines(filePath, Encoding.UTF8);
            foreach (var line in lines)
            {
                diaryText.Text += line;
                diaryText.Text += "\r\n";

                double diaryTextWidth = diaryText.Width;
            }
            

        }


        private void DeleteBtnClick(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("일기를 삭제하시겠습니까?", "YesOrNo", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                string appPath = AppDomain.CurrentDomain.BaseDirectory;
                string diaryPath = System.IO.Path.Combine(appPath, "Diary"); //다이어리까지 감 
                string titlePath = System.IO.Path.Combine(diaryPath, titleText.Content.ToString()); //파일까지 감 
                File.Delete(titlePath);
                this.Close();
            }

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
