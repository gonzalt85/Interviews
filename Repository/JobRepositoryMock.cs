using System;
using Interviews.Common.Interfaces;
using System.Collections.Generic;
using Interviews.Domain;

namespace Interviews.Repository
{
    public class JobRepositoryMock : JobRepository
    {
        private List<Job> _jobs = new List<Job>();
        public void Add(Job newJob)
        {
            _jobs.Add(newJob);            
        }       

        public Job Get(int id)
        {
            return _jobs.Find(j => j.Id == id);
        }
    }
}
