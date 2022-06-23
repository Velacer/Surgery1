using System;
using System.Collections.Generic;

#nullable disable

namespace Surgery1.Model
{
    public partial class Appointment
    {
        public Appointment()
        {
            OptionalAdds = new HashSet<OptionalAdd>();
            Totals = new HashSet<Total>();
        }

        public int Id { get; set; }
        public int ClientId { get; set; }
        public int PersonalId { get; set; }
        public int ServiceId { get; set; }
        public int DepartmentId { get; set; }

        public virtual Client Client { get; set; }
        public virtual Department Department { get; set; }
        public virtual Personal Personal { get; set; }
        public virtual Service Service { get; set; }
        public virtual ICollection<OptionalAdd> OptionalAdds { get; set; }
        public virtual ICollection<Total> Totals { get; set; }
    }
}
