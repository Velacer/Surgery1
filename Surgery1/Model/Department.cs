using System;
using System.Collections.Generic;

#nullable disable

namespace Surgery1.Model
{
    public partial class Department
    {
        public Department()
        {
            Appointments = new HashSet<Appointment>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string HeadOfDepartment { get; set; }
        public string Adress { get; set; }

        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}
