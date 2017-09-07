using Interviews.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interviews.Common.Interfaces
{
    public interface IRepository
    {
        #region Job Repository operations
        void AddJob(Job job);
        Job GetJob(int id);
        List<Job> ListJobs();
        void UpdateJob(Job job);
        void DeleteJob(Job job);
        #endregion

        #region Interview Repository operations
        void AddInterview(Interview interview);
        Job GetInterview(int id);
        List<Interview> ListInterviews();
        void UpdateInterviews(Interview interview);
        void DeleteInterviews(Interview interview);
        #endregion
    }
}
