using System;
using System.Collections.Generic;

#nullable disable

namespace Surgery1.Model
{
    public partial class Total
    {
        public int Id { get; set; }
        public int? AppointmetnId { get; set; }
        public decimal? TotalCost { get; set; }

        public virtual Appointment Appointmetn { get; set; }
    }
}
