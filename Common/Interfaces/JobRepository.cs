using System;

namespace Interviews.Common.Interfaces
{
    public interface JobRepository
    {
        void AddJob(Job newJob);       
        Job GetJob(int id);
    }
}
