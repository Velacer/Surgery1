using System;
using System.Collections.Generic;

#nullable disable

namespace Surgery1.Model
{
    public partial class Service
    {
        public Service()
        {
            Appointments = new HashSet<Appointment>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int? Category { get; set; }

        public virtual Category CategoryNavigation { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}
