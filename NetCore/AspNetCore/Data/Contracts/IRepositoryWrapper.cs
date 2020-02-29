using System.Threading.Tasks;

namespace AspNetCore.Data.Contracts
{
	public interface IRepositoryWrapper
    {
        IStudentRepository Student { get; }
        IClassRepository Class { get; }
        IEnrollmentRepository Enrollment { get; }
        Task SaveAsync();
    }
}
