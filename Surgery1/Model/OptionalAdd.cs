using System;
using System.Collections.Generic;

#nullable disable

namespace Surgery1.Model
{
    public partial class OptionalAdd
    {
        public int Id { get; set; }
        public int AdditionalServiceId { get; set; }
        public int AppointmentId { get; set; }

        public virtual AdditionalService AdditionalService { get; set; }
        public virtual Appointment Appointment { get; set; }
    }
}
