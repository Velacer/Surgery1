using System;
using System.Collections.Generic;

#nullable disable

namespace Surgery1.Model
{
    public partial class Appointment2
    {
        public int? Id { get; set; }
        public int? ServiceId { get; set; }
        public int? AppointmentId { get; set; }
        public int? Quantity { get; set; }
    }
}
