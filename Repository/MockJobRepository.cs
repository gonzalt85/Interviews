using System;
using Interviews.Common.Interfaces;
using System.Collections.Generic;
using Interviews.Domain;

namespace Interviews.Repository
{
    public class MockJobRepository : IJobRepository
    {
        private List<Job> _jobs = new List<Job>() {
            new Job { Id=1, Name = "test1"},
            new Job { Id=2, Name = "test2"},
            new Job { Id=3, Name = "test3"},
        };

        public void Add(Job job)
        {
            _jobs.Add(job);
        }

        public void Delete(Job job)
        {
            _jobs.Remove(job);
        }

        public Job Get(int id)
        {
            return _jobs.Find(j => j.Id == id);
        }

        public List<Job> List()
        {
            return _jobs;
        }

        public void Update(Job job)
        {
            _jobs.Remove(job);
            _jobs.Add(job);
        }
    }
}
