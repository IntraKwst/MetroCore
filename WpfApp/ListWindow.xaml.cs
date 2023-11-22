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

namespace WpfApp
{
    public partial class ListWindow : Window
    {
        private ListWindow(string username, List<Customer> customers)
        {
            InitializeComponent();
            DataContext = new
            {
                Username = username,
                Customers = customers
            };
        }

        /// <summary>
        /// used instead of constructor because it needs to be initialized asynchronously
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public static async Task<ListWindow> Initialize(string username)
        {
            var _customers = (await Requests.GetRequest<IEnumerable<Customer>>($"Queries/all/{1}/{20}")).ToList();
            return new ListWindow(username, _customers);
        }

        public async void ShowInvoice_OnClick(object sender, RoutedEventArgs e)
        {

        }

        public async void PDF_OnClick(object sender, RoutedEventArgs e)
        {

        }

        public async void Excel_OnClick(object sender, RoutedEventArgs e)
        {

        }

        public async void LogoutButton_OnClick(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();
            Close();
        }
    }
}
