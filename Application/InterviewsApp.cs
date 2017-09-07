using System;
using Interviews.Domain;
using System.Collections.Generic;
using Interviews.Common.Interfaces;

namespace Interviews.Application
{
    public class InterviewsApp
    {
        private readonly IJobRepository _jobRepository;
        private readonly IInterviewRepository _interviewRepository;

        public InterviewsApp(
            IJobRepository jobRepository, 
            IInterviewRepository interviewsRepository
            )
        {
            _jobRepository = jobRepository;
            _interviewRepository = interviewsRepository;            
        }

        #region Job operations
        public void AddJob(Job newJob)
        {
            _jobRepository.Add(newJob);
        }

        public Job GetJob(int id)
        {
            return _jobRepository.Get(id);
        }
        
        public void UpdateJob(Job job)
        {
            _jobRepository.Update(job);
        }

        public List<Job> ListJobs()
        {
            return _jobRepository.List();
        }

        public void DeleteJob(Job job)
        {
            _jobRepository.Delete(job);
        }
        #endregion

        #region Interview operations
        public void AddInterview(Interview interview)
        {
            _interviewRepository.Add(interview);
        }

        public Interview GetInterview(int id)
        {
            return _interviewRepository.Get(id);
        }

        public void UpdateInterview(Interview interview)
        {
            _interviewRepository.Update(interview);
        }

        public List<Interview> ListInterviews()
        {
            return _interviewRepository.List();
        }

        public void DeleteInterview(Interview interview)
        {
            _interviewRepository.Delete(interview);
        }
        #endregion
    }
}
