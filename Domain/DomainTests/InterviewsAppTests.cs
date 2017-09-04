using Microsoft.VisualStudio.TestTools.UnitTesting;
using Interviews.Domain;
using Interviews.Application;

namespace DomainTests
{
    [TestClass]
    public class InterviewsAppTests
    {
        [TestMethod]
        public void CreateJob()
        {
            InterviewsApp interviewsApp = new InterviewsApp();
            Job newJob = new Job { Id = 1 };
            interviewsApp.AddJob(newJob);
            var retrievedJob =  interviewsApp.GetJob(1);
            Assert.AreEqual(1, retrievedJob.Id);
        }
    }
}
