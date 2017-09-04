using System;
using Interviews.Common.Interfaces;

namespace Interviews.Repository
{
    public class JobRepositoryMock : JobRepository
    {
        public void AddJob(Job newJob)
        {
            throw new NotImplementedException();
        }

        public Job GetJob(int id)
        {
            throw new NotImplementedException();
        }
    }
}
