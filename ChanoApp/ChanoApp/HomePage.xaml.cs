using System;
using System.Collections.ObjectModel;
using System.IO;
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


            FolderListView.ItemsSource = Files;

            FileSystemWatcher watcher = new FileSystemWatcher();
            watcher.Path = diaryPath;
            watcher.Filter = "*.txt";//다이어리 패스의 텍스트 파일 감시중
            watcher.Created += new FileSystemEventHandler(OnCreated);
            watcher.EnableRaisingEvents = true;


            //diaryPath의 파일들 가져와서 
            //제목과 작성일을 알맞은 위치에 넣기
            string[] existingFiles = Directory.GetFiles(diaryPath, watcher.Filter);
            foreach (string file in existingFiles)
            {
                FileInfo fileInfo = new FileInfo(file);
                string fileName = fileInfo.Name; // 파일 이름
                string lastModified = fileInfo.LastWriteTime.ToString(); // 마지막 수정 날짜


                /*xaml의  
                 * <GridViewColumn x:Name="Title" Header="제목" DisplayMemberBinding="{Binding Name}"/> -> fileName 바인딩
                 * <GridViewColumn x:Name="Date" Header="작성일" DisplayMemberBinding="{Binding LastModified}"/>  ->lasModified 바인딩 
                    각각 바인딩해서 추가해주면 좋겠어 
                 */
                diaryEntries.Add(new DiaryEntry { Name = fileName, LastModified = lastModified });

            }
            FolderListView.ItemsSource = diaryEntries;
        }


        private void OnCreated(object source, FileSystemEventArgs e)
        {
            // 새 파일이 추가될 때 ObservableCollection에 추가
            Application.Current.Dispatcher.Invoke(() =>
            {
                FileInfo fileInfo = new FileInfo(e.FullPath);
                string fileName = fileInfo.Name; // 파일 이름
                string lastModified=fileInfo.LastWriteTime.ToString();

                //다이어리 엔트리 만들어서 콜랙션에 넣기?
                diaryEntries.Add(new DiaryEntry { Name = fileName, LastModified = lastModified });

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
