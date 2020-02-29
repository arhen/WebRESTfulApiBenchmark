using System.Collections.Generic;
using System.Threading.Tasks;
using AspNetCore.Data.Entities.Dto;
using AspNetCore.Data.Entities.Models;

namespace AspNetCore.Data.Contracts
{
	public interface IStudentRepository
    {
		Task<IEnumerable<Students>> GetAllAsync();
    }
}
