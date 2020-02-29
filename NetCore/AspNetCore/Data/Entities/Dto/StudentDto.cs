using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace AspNetCore.Data.Entities.Dto
{
    public partial class StudentDto
    {
        public int StudentId { get; set; }

		[JsonIgnore]
        public string Firstname { get; set; }

		[JsonIgnore]
        public string Lastname { get; set; }
        public DateTime Birthdate { get; set; }
		public string Fullname => $"{Firstname} {Lastname}";
    }
}
