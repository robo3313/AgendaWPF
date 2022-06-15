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

namespace AgendaWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            NavigateToAppointmentsList();
        }

        private void MenuItem_AddCustomer(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Uri("Pages/AddCustomer.xaml", UriKind.Relative));
        }

        private void MenuItem_ListCustomer(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Uri("Pages/ListCustomer.xaml", UriKind.Relative));
        }

        private void MenuItem_AddBroker(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Uri("Pages/AddBroker.xaml", UriKind.Relative));
        }

        private void MenuItem_ListBroker(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Uri("Pages/ListBroker.xaml", UriKind.Relative));
        }

        private void MenuItem_AddAppointment(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Uri("Pages/AddAppointment.xaml", UriKind.Relative));
        }

        private void MenuItem_ListAppointment(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Uri("Pages/ListAppointment.xaml", UriKind.Relative));
        }

        public void NavigateToCustomersList()
        {
            MainFrame.Navigate(new Uri("Pages/ListCustomer.xaml", UriKind.Relative));
        }

        public void NavigateToBrokersList()
        {
            MainFrame.Navigate(new Uri("Pages/ListBroker.xaml", UriKind.Relative));
        }

        public void NavigateToAppointmentsList()
        {
            MainFrame.Navigate(new Uri("Pages/ListAppointment.xaml", UriKind.Relative));
        }
    }
}
