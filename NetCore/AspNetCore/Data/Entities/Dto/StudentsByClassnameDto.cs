using System.Collections.Generic;
using System.Text.Json.Serialization;
using AspNetCore.Data.Entities.Models;

namespace AspNetCore.Data.Entities.Dto
{
	public class StudentByClassnameDto
	{
		public int StudentId { get; set; }

		[JsonIgnore]
		public string Firstname { get; set; }
		[JsonIgnore]
		public string Lastname { get; set; }

		public string Fullname => $"{Firstname} {Lastname}";
		public string Birthdate { get; set; }
		public IEnumerable<Classes> EnrollmentClass {get; set;}

	}
}
