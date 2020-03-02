using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCore.Data.Contracts;
using AspNetCore.Data.Entities;
using AspNetCore.Data.Entities.Dto;
using AspNetCore.Data.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace AspNetCore.Data.Repositories
{
    public class EnrollmentRepository : RepositoryBase<Enrollments>, IEnrollmentRepository
    {
        public EnrollmentRepository(RepositoryContext repositoryContext)
            :base(repositoryContext)
        {
        }

		public async Task<IEnumerable<StudentByClassnameDto>> GetStudentsByClassname(string className){

			return await FindAll()
				.Where(enrollment => enrollment.Class.Title == className)
				.OrderBy(enrollment => enrollment.Student.Firstname) //Order by firstname
				.ThenByDescending(enrollment => enrollment.Student.Lastname) //then order by lastname
				.Select(enrollment => new StudentByClassnameDto{ //List all student data based on the mathematics class they enrolled
					StudentId = enrollment.Student.StudentId,
					Firstname = enrollment.Student.Firstname,
					Lastname = enrollment.Student.Lastname,
					Birthdate = enrollment.Student.Birthdate.ToString("dd MMMM yyyy"),
					EnrollmentClass =  enrollment.Student.Enrollments //Get all enrolled classes by current student
						.Where(m => m.StudentId == enrollment.StudentId)
						.OrderBy(m => m.Class.Title) //Order class by className
						.Select(m => m.Class)
						.ToList()
				})
				.ToListAsync();
		}
	}
}
