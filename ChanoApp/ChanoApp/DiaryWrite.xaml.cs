using Microsoft.Win32;
using System;
using System.IO;
using System.Windows;

namespace ChanoApp
{
    /// <summary>
    /// DiaryWrite.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class DiaryWrite : Window
    {

        //작성중인 파일 경로 

        private bool textChanged = false;

        public DiaryWrite()
        {
            InitializeComponent();
        }




        private void NewFileBtnClick(object sender, RoutedEventArgs e)
        {
            if (textChanged)
            {
                MessageBoxResult result = MessageBox.Show("변경된 내용을 저장하시겠습니까?", "저장", MessageBoxButton.YesNoCancel, MessageBoxImage.Question);


                if (result == MessageBoxResult.Yes)
                {
                    SaveFile();
                }
                else if (result == MessageBoxResult.Cancel)
                {
                    return;
                }
            }
            titleText.Text = string.Empty;
            diaryText.Text = string.Empty;

        }


        private void NewTabBtnClick(object sender, RoutedEventArgs e)
        {

            var window = new DiaryWrite();

            window.Owner = Application.Current.MainWindow;
            window.Show();
        }


        private void SaveBtnClick(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(titleText.Text) || string.IsNullOrEmpty(diaryText.Text))
            {
                MessageBox.Show("제목이나 내용이 비어있습니다.");
            }
            SaveFile();

        }



        //파일저장

        private void SaveFile()
        {
            //위에서 없는건 처리함 
            string textFile = "Diary\\" + titleText + ".txt";

            if (File.Exists(textFile))
            {
                MessageBoxResult result = MessageBox.Show("같은 이름의 파일이 이미 존재합니다. 덮어쓰시겠습니까?", "덮어쓰기", MessageBoxButton.YesNoCancel, MessageBoxImage.Question);

                if (result == MessageBoxResult.Cancel)
                {
                    return; //취소 
                }
            }


            //----------여기부터 저장 


            string appPath = AppDomain.CurrentDomain.BaseDirectory;
            string diaryPath = System.IO.Path.Combine(appPath, "Diary");

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = diaryPath;
            saveFileDialog.FileName = titleText.Text;
            saveFileDialog.DefaultExt = ".txt";
            saveFileDialog.Filter = "Text documents (.txt)|*.txt";

            if (saveFileDialog.ShowDialog() == true)
            {
                File.WriteAllText(saveFileDialog.FileName, diaryText.Text);
            }
            //이어서 짜기 


        }

        private void diaryText_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            textChanged = true;
        }
    }
}
