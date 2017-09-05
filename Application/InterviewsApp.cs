using System;
using Interviews.Domain;
using System.Collections.Generic;
using Interviews.Common.Interfaces;

namespace Interviews.Application
{
    public class InterviewsApp
    {
        private IJobRepository _jobRepository;
        public InterviewsApp(IJobRepository jobRepository)
        {
            _jobRepository = jobRepository;
        }
        public void AddJob(Job newJob)
        {
            _jobRepository.Add(newJob);
        }

        public Job GetJob(int id)
        {
            return _jobRepository.Get(id);
        }        
    }
}
