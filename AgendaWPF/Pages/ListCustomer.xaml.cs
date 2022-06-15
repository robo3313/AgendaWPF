using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace AgendaWPF.Models;

/// <summary>
/// Interaction logic for ListCustomer.xaml
/// </summary>
public partial class ListCustomer : Page
{
    private readonly AgendaContext _context;
    private Customer currentCustomer;
    public ListCustomer()
    {
        InitializeComponent();
        _context = new AgendaContext();
        DisplayList();
    }

    private void DisplayList()
    {
        CustomerGrid.ItemsSource = _context.Customers.ToList();
    }

    public void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        try {
            currentCustomer = (Customer)CustomerGrid.SelectedItem; //Datagrid bound with ProductItem 
            DataContext = currentCustomer;
        } catch {
            DataContext = null;
        }
    }

    private void Button_Update(object sender, RoutedEventArgs e)
    {
        _context.Update(currentCustomer);
        _context.SaveChanges();
    }

    private void Button_Delete(object sender, RoutedEventArgs e)
    {
        _context.Remove(currentCustomer);
        _context.SaveChanges();
        DisplayList();
    }
}
