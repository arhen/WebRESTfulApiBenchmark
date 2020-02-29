using System.Threading.Tasks;
using AspNetCore.Data.Contracts;
using AspNetCore.Data.Entities;

namespace AspNetCore.Data.Repositories
{
	public class RepositoryWrapper : IRepositoryWrapper
    {
        private RepositoryContext _repoContext;
        private IStudentRepository _student;
        private IClassRepository _class;
        private IEnrollmentRepository _enrollment;

        public IStudentRepository Student {
            get {
                if(_student == null)
                {
                    _student = new StudentRepository(_repoContext);
                }

                return _student;
            }
        }

        public IClassRepository Class {
            get {
                if(_class == null)
                {
                    _class = new ClassRepository(_repoContext);
                }

                return _class;
            }
        }

		public IEnrollmentRepository Enrollment {
            get {
                if(_enrollment == null)
                {
                    _enrollment = new EnrollmentRepository(_repoContext);
                }

                return _enrollment;
            }
        }

		public RepositoryWrapper(RepositoryContext repositoryContext) => _repoContext = repositoryContext;

		public async Task SaveAsync() => await _repoContext.SaveChangesAsync();
	}
}
