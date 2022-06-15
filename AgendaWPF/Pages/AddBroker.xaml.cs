using System;
using System.Windows;
using System.Windows.Controls;

namespace AgendaWPF.Models;

/// <summary>
/// Interaction logic for AddCustomer.xaml
/// </summary>
public partial class AddBroker : Page
{
    private readonly AgendaContext _context = new();
    private Broker broker = new();
    public AddBroker()
    {
        InitializeComponent();
        DataContext = broker;
    }

    private void Button_Add(object sender, RoutedEventArgs e)
    {
        _context.Add(broker);

        try {
            _context.SaveChanges();
            MessageBox.Show("Le courtier a bien été créé.");
            MainWindow tmp = (MainWindow)Application.Current.MainWindow;
            tmp.NavigateToBrokersList();
        } catch (Exception exception) {
            MessageBox.Show("Le coutier n'a pas pu être créé.");
        }
    }
}
