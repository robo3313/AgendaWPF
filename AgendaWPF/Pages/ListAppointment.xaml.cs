using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace AgendaWPF.Models;

/// <summary>
/// Interaction logic for ListAppointment.xaml
/// </summary>
public partial class ListAppointment : Page
{
    private readonly AgendaContext _context;
    private readonly List<Customer> _customerList;
    private readonly List<Broker> _brokerList;
    private AppointmentViewModel res;
    public ListAppointment()
    {
        InitializeComponent();
        _context = new AgendaContext();
        _customerList = _context.Customers.ToList();
        _brokerList = _context.Brokers.ToList();
        DisplayList();
    }

    private void DisplayList()
    {
        AppointmentGrid.ItemsSource = _context.Appointments.Include(a => a.IdBrokersNavigation).Include(a => a.IdCustomersNavigation).ToList();
    }

    public void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        try {
            res = new();
            res.appointment = (Appointment)AppointmentGrid.SelectedItem;
            res.customers = _customerList;
            res.brokers = _brokerList;
            DataContext = res;
        } catch {
            DataContext = null;
        }
    }

    private void Button_Update(object sender, RoutedEventArgs e)
    {
        _context.Update(res.appointment);
        _context.SaveChanges();
        DisplayList();
    }

    private void Button_Delete(object sender, RoutedEventArgs e)
    {
        _context.Remove(res.appointment);
        _context.SaveChanges();
        DisplayList();
    }
}
