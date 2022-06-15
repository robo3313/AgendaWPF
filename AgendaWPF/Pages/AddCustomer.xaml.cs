using System;
using System.Windows;
using System.Windows.Controls;

namespace AgendaWPF.Models;

/// <summary>
/// Interaction logic for AddCustomer.xaml
/// </summary>
public partial class AddCustomer : Page
{
    private readonly AgendaContext _context = new();
    private Customer customer = new();
    public AddCustomer()
    {
        InitializeComponent();
        DataContext = customer;
    }

    private void Button_Add(object sender, RoutedEventArgs e)
    {
        _context.Add(customer);

        try {
            _context.SaveChanges();
            MessageBox.Show("Le client a bien été créé.");
            MainWindow tmp = (MainWindow)Application.Current.MainWindow;
            tmp.NavigateToCustomersList();
        } catch (Exception exception) {
            MessageBox.Show("L'utilisateur n'a pas pu être créé.");
        }
    }
}
