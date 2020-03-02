using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCore.Data.Contracts;
using AspNetCore.Data.Entities;
using AspNetCore.Data.Entities.Models;
using AspNetCore.Data.Repositories;
using Microsoft.EntityFrameworkCore;

namespace  AspNetCore.Data.Repositories
{
    public class ClassRepository : RepositoryBase<Classes>, IClassRepository
    {
        public ClassRepository(RepositoryContext repositoryContext)
            :base(repositoryContext)
        {
        }
	}
}
