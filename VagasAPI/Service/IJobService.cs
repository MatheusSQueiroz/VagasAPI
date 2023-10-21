using VagasAPI.Model;

namespace VagasAPI.Service
{
    public interface IJobService
    {
        Task<IEnumerable<Job>> GetAll();

        Task<Job?> GetById(long id);

        Task<IEnumerable<Job?>> GetByTitle(string title);

        Task<Job?> Create(Job job);

        Task<Job?> Update(Job job);

        Task Delete(Job job);
    }
}
