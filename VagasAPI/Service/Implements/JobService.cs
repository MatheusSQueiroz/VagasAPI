﻿using VagasAPI.Model;

namespace VagasAPI.Service.Implements
{
    public class JobService : IJobService
    {
        public JobService()
        {
        }

        public Task<Job?> Create(Job job)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Job job)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Job>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Job?> GetById(long id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Job?>> GetByTitle(string title)
        {
            throw new NotImplementedException();
        }

        public Task<Job?> Update(Job job)
        {
            throw new NotImplementedException();
        }
    }
}