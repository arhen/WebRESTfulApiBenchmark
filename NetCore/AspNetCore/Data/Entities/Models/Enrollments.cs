using System;
using System.Collections.Generic;

namespace AspNetCore.Data.Entities.Models
{
    public partial class Enrollments
    {
        public int EnrollmentId { get; set; }
        public int StudentId { get; set; }
        public int ClassId { get; set; }

        public virtual Classes Class { get; set; }
        public virtual Students Student { get; set; }
    }
}
