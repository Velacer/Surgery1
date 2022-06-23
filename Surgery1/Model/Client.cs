using System;
using System.Collections.Generic;

#nullable disable

namespace Surgery1.Model
{
    public partial class Client
    {
        public Client()
        {
            Appointments = new HashSet<Appointment>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Discount { get; set; }

        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}
