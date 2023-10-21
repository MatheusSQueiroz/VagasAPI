using VagasAPI.Data;
using VagasAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace VagasAPI.Service.Implements
{
    public class JobService : IJobService
    {
        private readonly AppDbContext _context;

        public JobService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Job>> GetAll()
        {
            return await _context.Jobs
                .ToListAsync();
        }

        public async Task<Job?> GetById(long id)
        {
            try
            {

                var Vagas = await _context.Jobs
                        .FirstAsync(i => i.Id == id);
                return Vagas;

            }
            catch
            {
                return null;
            }

        }

        public async Task<IEnumerable<Job?>> GetByTitle(string title)
        {
            var Postagem = await _context.Jobs
                                 .Where(p => p.Title.Contains(title))
                                 .ToListAsync();
            return Postagem;
        }

        public async Task<Job?> Create(Job job)
        {
            await _context.Jobs.AddAsync(job);
            await _context.SaveChangesAsync();

            return job;
        }


        public async Task<Job?> Update(Job job)
        {
            var JobUpdate = await _context.Jobs.FindAsync(job.Id);

            if (JobUpdate is null)
                return null;

            _context.Entry(JobUpdate).State = EntityState.Detached;
            _context.Entry(job).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return job;
        }
        public async Task Delete(Job job)
        {
            _context.Remove(job);
            await _context.SaveChangesAsync();
        }
    }
}
