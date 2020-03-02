using System.Collections.Generic;
using System.Threading.Tasks;
using AspNetCore.Data.Entities.Dto;
using AspNetCore.Data.Entities.Models;

namespace AspNetCore.Data.Contracts
{
	public interface IEnrollmentRepository
    {
		Task<IEnumerable<StudentByClassnameDto>> GetStudentsByClassname(string className);
    }
}
