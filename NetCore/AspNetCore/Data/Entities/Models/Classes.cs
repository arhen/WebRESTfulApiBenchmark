using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace AspNetCore.Data.Entities.Models
{
    public partial class Classes
    {
        public Classes()
        {
            Enrollments = new HashSet<Enrollments>();
        }

        public int ClassId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

		[JsonIgnore]
        public virtual ICollection<Enrollments> Enrollments { get; set; }
    }
}
