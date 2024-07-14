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
using System.Windows.Shapes;

namespace ChanoApp
{
    /// <summary>
    /// UserSettings.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class UserSettings : Window
    {

        public UserSettings()
        {
            InitializeComponent();
        }

        private string userPw = Properties.Settings.Default.userpw;

        private void IdChangeBtn_Click(object sender, RoutedEventArgs e)
        {
            string newId = NewId.Text;
            string userPasswd = UserPasswd.Password;

            if (String.IsNullOrEmpty(newId))
            {
                MessageBox.Show("새로운 id를 입력해주세요");
            }
            if (!userPasswd.Equals(userPw))
            {
                MessageBox.Show("올바른 비밀번호를 입력해주세요");
            }
            else
            {
                Properties.Settings.Default.userid = newId;
                Properties.Settings.Default.Save();
                MessageBox.Show("id 변경 성공");
            }
        }

        private void PwChangeBtn_Click(object sender, RoutedEventArgs e)
        {
            string newPasswd1 = NewPasswd1.Password;
            string newPasswd2 = NewPasswd2.Password;

            if (String.IsNullOrEmpty(newPasswd1))
            {
                MessageBox.Show("새로운 비밀번호를 입력해주세요");
            }
            else if (String.IsNullOrEmpty(newPasswd2))
            {
                MessageBox.Show("비밀번호를 한번 더 입력해주세요");
            }
            else if (newPasswd1.Equals(newPasswd2))
            {
                Properties.Settings.Default.userpw = newPasswd1;
                Properties.Settings.Default.Save();
                userPw = newPasswd1;
                MessageBox.Show("비밀번호 변경 성공");
            }
            else
            {
                MessageBox.Show("비밀번호 변경 실패");
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
