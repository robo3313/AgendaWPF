using System;
using System.Collections.Generic;

namespace AgendaWPF.Models
{
    public partial class AppointmentViewModel
    {
        public Appointment appointment { get; set; }
        public List<Customer> customers { get; set; }
        public List<Broker> brokers { get; set; }
    }
}
