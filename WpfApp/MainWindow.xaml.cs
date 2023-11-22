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

namespace WpfApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void LoginButton_OnClick(object sender, RoutedEventArgs e)
        {
            string username = UsernameTextBox.Text;
            string password = PasswordBox.Password;
            try
            {
                await Requests.GetRequest<object>($"Users/exists/{username}/{password}");
            }
            catch
            {
                MessageBox.Show("User not found");
                return;
            }
            (await ListWindow.Initialize(username)).Show();
            Close();
        }

        private async void CreateAccountButton_OnClick(object sender, RoutedEventArgs e)
        {
            string username = UsernameTextBox.Text;
            string password = PasswordBox.Password;
            try
            {
                await Requests.GetRequest<object>($"Users/create/{username}/{password}");
            }
            catch
            {
                MessageBox.Show("Error");
                return;
            }

            MessageBox.Show("Account created successfully");
            (await ListWindow.Initialize(username)).Show();
            Close();
        }
    }
}
