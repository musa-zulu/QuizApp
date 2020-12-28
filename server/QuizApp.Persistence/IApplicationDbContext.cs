using System.Threading.Tasks;

namespace QuizApp.Persistence
{
    public interface IApplicationDbContext
    {
        Task<int> SaveChangesAsync();
    }
}
