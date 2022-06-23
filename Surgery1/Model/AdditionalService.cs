using System;
using System.Collections.Generic;

#nullable disable

namespace Surgery1.Model
{
    public partial class AdditionalService
    {
        public AdditionalService()
        {
            OptionalAdds = new HashSet<OptionalAdd>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal? Cost { get; set; }
        public string Comment { get; set; }

        public virtual ICollection<OptionalAdd> OptionalAdds { get; set; }
    }
}
