using System;
using System.Windows;
using System.Windows.Navigation;

namespace ChanoApp
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        private Uri uri = new Uri("HomePage.xaml", UriKind.Relative);

   
        public MainWindow()
        {
            InitializeComponent();
         
        }
        private string userId = Properties.Settings.Default.userid;
        private string userPw = Properties.Settings.Default.userpw;





        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string inputId = idBox.Text;
            string inputPw = pwBox.Password;

            if (inputId.Equals(userId) && inputPw.Equals(userPw))
            {
                MessageBox.Show("로그인 성공", "로그인");
                //로그인 성공 메세지와 창 이름 

                
               
                 mainFrame.Navigate(uri);
               
                this.Height = 400;
                this.Width = 820;

                this.Left = (SystemParameters.PrimaryScreenWidth - this.Width) / 2;
                this.Top = (SystemParameters.PrimaryScreenHeight - this.Height) / 2;

              

            }
            else
            {
                MessageBox.Show("로그인 실패", "로그인");
            }
        }

        private void mainFrame_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}
