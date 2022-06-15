using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace AgendaWPF.Models;

/// <summary>
/// Interaction logic for AddCustomer.xaml
/// </summary>
public partial class AddAppointment : Page
{
    private readonly AgendaContext _context = new();
    private readonly AppointmentViewModel res = new();
    public AddAppointment()
    {
        InitializeComponent();
        res.customers = _context.Customers.ToList();
        res.brokers = _context.Brokers.ToList();
        res.appointment = new();
        DataContext = res;
    }

    private void Button_Add(object sender, RoutedEventArgs e)
    {
        _context.Add(res.appointment);

        try {
            _context.SaveChanges();
            MessageBox.Show("Le rendez-vous a bien été créé.");
            MainWindow tmp = (MainWindow)Application.Current.MainWindow;
            tmp.NavigateToAppointmentsList();
        } catch (Exception exception) {
            MessageBox.Show("Le rendez-vous n'a pas pu être créé : "+exception.ToString());
        }
    }
}
