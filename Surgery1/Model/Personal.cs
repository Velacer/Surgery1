using System;
using System.Collections.Generic;

#nullable disable

namespace Surgery1.Model
{
    public partial class Personal
    {
        public Personal()
        {
            Appointments = new HashSet<Appointment>();
        }

        public int Id { get; set; }
        public string PassportData { get; set; }
        public string Qualification { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }

        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}
