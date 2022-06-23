using System;
using System.Collections.Generic;

#nullable disable

namespace Surgery1.Model
{
    public partial class Category
    {
        public Category()
        {
            Services = new HashSet<Service>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Service> Services { get; set; }
    }
}
