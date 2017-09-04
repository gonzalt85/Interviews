using System;
using Interviews.Domain;
using System.Collections.Generic;

namespace Interviews.Application
{
    public class InterviewsApp
    {
        private List<Job> _jobs = new List<Job>();
        public void AddJob(Job newJob)
        {
            _jobs.Add(newJob);
        }

        public Job GetJob(int id) => _jobs.Find(j => j.Id == id);       
    }
}
