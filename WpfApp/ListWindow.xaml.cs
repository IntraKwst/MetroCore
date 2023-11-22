using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
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
                Customers = customers,
                Invoices = new List<CustomerInvoice>()
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
            var customer = (e.Source as Button).DataContext as Customer;
            var invoices = (await Requests.GetRequest<IEnumerable<CustomerInvoice>>($"Queries/allInvoices/{customer.CusCode}")).ToList();
        }

        public async void PDF_OnClick(object sender, RoutedEventArgs e)
        {
            var customer = (e.Source as Button).DataContext as Customer;
            var invoices = (await Requests.GetRequest<IEnumerable<CustomerInvoice>>($"Queries/allInvoices/{customer.CusCode}")).ToList();

            using (var pdfCreator = new PdfCreator(ListWindowHelpers.CreateHtml(invoices)))
            {
                // do sth with the stream
            }
        }

        public async void Excel_OnClick(object sender, RoutedEventArgs e)
        {
            var customer = (e.Source as Button).DataContext as Customer;
            var invoices = (await Requests.GetRequest<IEnumerable<CustomerInvoice>>($"Queries/allInvoices/{customer.CusCode}")).ToList();
            using (var writer = new StreamWriter(new MemoryStream()))
            {
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csv.WriteRecords(invoices);
                    csv.Flush();
                }
                writer.Flush();
            }
            
        }

        public void LogoutButton_OnClick(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();
            Close();
        }
    }
}
