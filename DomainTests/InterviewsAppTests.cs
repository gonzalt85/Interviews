using Microsoft.VisualStudio.TestTools.UnitTesting;
using Interviews.Domain;
using Interviews.Application;
using Interviews.Repository;

namespace DomainTests
{
    [TestClass]
    public class InterviewsAppTests
    {
        [TestMethod]
        public void CreateJob()
        {
            InterviewsApp interviewsApp = new InterviewsApp(new JobRepositoryMock());
            Job newJob = new Job { Id = 1 };
            interviewsApp.AddJob(newJob);
            var retrievedJob =  interviewsApp.GetJob(1);
            Assert.AreEqual(1, retrievedJob.Id);
        }
    }
}
