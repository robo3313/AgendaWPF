using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace AgendaWPF.Models;

/// <summary>
/// Interaction logic for ListCustomer.xaml
/// </summary>
public partial class ListBroker : Page
{
    private readonly AgendaContext _context;
    private Broker currentBroker;
    public ListBroker()
    {
        InitializeComponent();
        _context = new AgendaContext();
        DisplayList();
    }

    private void DisplayList()
    {
        BrokerGrid.ItemsSource = _context.Brokers.ToList();
    }

    public void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        try {
            currentBroker = (Broker)BrokerGrid.SelectedItem; //Datagrid bound with ProductItem 
            DataContext = currentBroker;
        } catch {
            DataContext = null;
        }
    }

    private void Button_Update(object sender, RoutedEventArgs e)
    {
        _context.Update(currentBroker);
        _context.SaveChanges();
    }

    private void Button_Delete(object sender, RoutedEventArgs e)
    {
        _context.Remove(currentBroker);
        _context.SaveChanges();
        DisplayList();
    }
}
