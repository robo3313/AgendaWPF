using System;
using System.Collections.Generic;

namespace AgendaWPF.Models
{
    public partial class Broker
    {
        public Broker()
        {
            Appointments = new HashSet<Appointment>();
        }

        public int Id { get; set; }
        public string Lastname { get; set; } = null!;
        public string Firstname { get; set; } = null!;
        public string Mail { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;

        public virtual ICollection<Appointment> Appointments { get; set; }

        public string Fullname { get => Firstname + ' ' + Lastname; }
    }
}
