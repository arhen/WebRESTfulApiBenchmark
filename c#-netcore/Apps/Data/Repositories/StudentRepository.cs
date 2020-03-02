using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCore.Data.Contracts;
using AspNetCore.Data.Entities;
using AspNetCore.Data.Entities.Dto;
using AspNetCore.Data.Entities.Models;
using AspNetCore.Data.Repositories;
using Microsoft.EntityFrameworkCore;

namespace AspNetCore.Data.Repositories
{
    public class StudentRepository : RepositoryBase<Students>, IStudentRepository
    {
        public StudentRepository(RepositoryContext repositoryContext)
            :base(repositoryContext)
        {
        }

		public async Task<IEnumerable<Students>> GetAllAsync() => await FindAll().ToListAsync();

	}
}
