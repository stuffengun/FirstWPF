using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;

namespace ChanoApp
{
    /// <summary>
    /// HomePage.xaml에 대한 상호 작용 논리
    /// </summary>
    /// 
    public class DiaryEntry
    {
        public string Name { get; set; }
        public string LastModified { get; set; }
    }


    public partial class HomePage : Page
    {
        string diaryPath = "Diary";

        ObservableCollection<string> Files = new ObservableCollection<string>();

        ObservableCollection<DiaryEntry> diaryEntries = new ObservableCollection<DiaryEntry>();

        public HomePage()
        {
            InitializeComponent();

            if (!Directory.Exists(diaryPath))
            {
                Directory.CreateDirectory(diaryPath);

                MessageBox.Show(Directory.Exists(diaryPath).ToString());
            }

            DirectoryInfo dirinfo = new DirectoryInfo(diaryPath);
            dirinfo.Attributes |= FileAttributes.Hidden;


            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Tick += TimerTick;
            timer.Start();

            DateShow.Content = DateTime.Now.ToString("yyyy-mm-dd : ddd");
            TimeShow.Content = DateTime.Now.ToString("hh:mm:ss");


            FileSystemWatcher watcher = new FileSystemWatcher();
            watcher.Path = diaryPath;
            watcher.Filter = "*.txt"; //다이어리 패스의 텍스트 파일 감시중

            // 이벤트 핸들러를 등록하기 전에 기존 파일을 불러옵니다.
            string[] existingFiles = Directory.GetFiles(diaryPath, watcher.Filter);
            foreach (string file in existingFiles)
            {
                FileInfo fileInfo = new FileInfo(file);
                string fileName = fileInfo.Name; // 파일 이름
                string lastModified = fileInfo.LastWriteTime.ToString(); // 마지막 수정 날짜

                diaryEntries.Add(new DiaryEntry { Name = fileName, LastModified = lastModified });
            }
            FolderListView.ItemsSource = diaryEntries;

            // 기존 파일을 불러온 후에 이벤트 핸들러를 등록합니다.
            watcher.Created += new FileSystemEventHandler(OnCreated); // 수정된 부분
            watcher.EnableRaisingEvents = true;
        }


        private void OnCreated(object source, FileSystemEventArgs e)
        {
            // 새 파일이 추가될 때 ObservableCollection에 추가
            Application.Current.Dispatcher.Invoke(() =>
            {
                FileInfo fileInfo = new FileInfo(e.FullPath);
                string fileName = fileInfo.Name; // 파일 이름
                string lastModified = fileInfo.LastWriteTime.ToString();

                // 다이어리 엔트리가 이미 존재하는지 확인
                var existingEntry = diaryEntries.FirstOrDefault(entry => entry.Name == fileName);
                if (existingEntry == null)
                {
                    // 다이어리 엔트리가 존재하지 않으면 새 엔트리를 추가
                    diaryEntries.Add(new DiaryEntry { Name = fileName, LastModified = lastModified });
                }
            });
        }





        private void TimerTick(object sender, EventArgs e)
        {
            TimeShow.Content = DateTime.Now.ToString("hh:mm:ss");
            DateShow.Content = DateTime.Now.ToString("yyyy-mm-dd : ddd");
        }




        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }


        private void SettingClick(object sender, RoutedEventArgs e)
        {
            var window = new UserSettings();

            window.Owner = Application.Current.MainWindow;
            window.Show();
        }

        private void NewClick(object sender, RoutedEventArgs e)
        {
            var window = new DiaryWrite();

            window.Owner = Application.Current.MainWindow;
            window.Show();
        }

        private void HelpClick(object sender, RoutedEventArgs e)
        {
            var window = new Help();

            window.Owner = Application.Current.MainWindow;
            window.Show();
        }
    }
}
