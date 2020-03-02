using System;
using System.Collections.Generic;

namespace AspNetCore.Data.Entities.Models
{
    public partial class Students
    {
        public Students()
        {
            Enrollments = new HashSet<Enrollments>();
        }
        public int StudentId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime Birthdate { get; set; }

        public virtual ICollection<Enrollments> Enrollments { get; set; }
    }
}
