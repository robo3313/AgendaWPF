using System;
using System.Collections.Generic;

namespace AgendaWPF.Models
{
    public partial class Appointment
    {
        public int Id { get; set; }
        public DateTime DateHour { get; set; }
        public string Subject { get; set; } = null!;
        public int? IdBrokers { get; set; }
        public int? IdCustomers { get; set; }

        public virtual Broker? IdBrokersNavigation { get; set; }
        public virtual Customer? IdCustomersNavigation { get; set; }
    }
}
