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

namespace Subscriber
{
    /// <summary>
    /// Interaction logic for LoginForm.xaml
    /// </summary>
    public partial class LoginForm : Window
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void AuthCheck()
        {


            if (MainWindow.logedUser.LogCheck(logTextBox.Text, passwordTextBox.Text) == 2)
            {
                // // Якщо введені користувачем дані відповідають Editor's, то
                // головна форма відображається, а форма "Авторизація" закривається.
                Application.Current.MainWindow.Show();
                this.Close();
            }
            else
            {
                // Якщо введені користувачем дані не відповідають Editor'у, то
                // виводиться повідомлення.
                MessageBox.Show("Введіть правильні дані авторизації.", "Помилка!",
                MessageBoxButton.OK, MessageBoxImage.Exclamation);

            }
        }

        private void okButton_Click(object sender, RoutedEventArgs e)
        {
            AuthCheck();
        }
        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                AuthCheck();
            }
        }

        private void LoginForm1_Closed(object sender, EventArgs e)
        {
            Application.Current.MainWindow.Show();
        }


        // ARSENIY 


        //private void Window_Closed(object sender, EventArgs e)
        //{
        //    Application.Current.MainWindow.Show();
        //}

        //private void loginButton_Click(object sender, RoutedEventArgs e)
        //{
        //    LoginCheck();
        //}

        //private void LoginCheck()
        //{
        //    string login = LoginTextBox.Text;
        //    string password = PasswordBox.Password;
        //    if (MainWindow.loginEditor.Login(login, password))
        //    {
        //        MainWindow.loginEditor.isEditor = true;
        //        this.Close();
        //    }
        //    else
        //    {
        //        MainWindow.loginEditor.isEditor = false;
        //        MessageBox.Show("Введіть коректні дані авторизації", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
        //    }
        //}

        //private void Grid_KeyDown(object sender, KeyEventArgs e)
        //{

        //}

        //private void LoginForm1_KeyDown(object sender, KeyEventArgs e)
        //{

        //}

       
    }
}

