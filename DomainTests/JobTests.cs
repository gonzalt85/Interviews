using Microsoft.VisualStudio.TestTools.UnitTesting;
using Interviews.Domain;
using Interviews.Application;
using Interviews.Repository;

namespace DomainTests
{
    [TestClass]
    public class JobTests
    {
        [TestMethod]
        public void CreateAndGetJob()
        {
            InterviewsApp interviewsApp = new InterviewsApp(
                new MockJobRepository(),
                new MockInterviewRepository()
                );
            
            interviewsApp.AddJob(new Job { Id = 1, Name = "Test" });
            var retrievedJob =  interviewsApp.GetJob(1);

            Assert.AreEqual(1, retrievedJob.Id);
            Assert.AreEqual("Test", retrievedJob.Name);
        }

        [TestMethod]
        public void GetListOfJobs()
        {

            InterviewsApp interviewsApp = new InterviewsApp(
                new MockJobRepository(),
                new MockInterviewRepository()
                );

            interviewsApp.AddJob(new Job { Id = 1, Name = "Test1" });
            interviewsApp.AddJob(new Job { Id = 2, Name = "Test2" });
            
            Assert.AreEqual(2, interviewsApp.ListJobs().Count);            
        }

        [TestMethod]
        public void UpdateJob()
        {
            //ARRANGE
            InterviewsApp interviewsApp = new InterviewsApp(
                new MockJobRepository(),
                new MockInterviewRepository()
                );
            interviewsApp.AddJob(new Job { Id = 1, Name = "Test1" });
            interviewsApp.AddJob(new Job { Id = 2, Name = "Test2" });

            //ACT
            var job = interviewsApp.GetJob(1);
            job.Name = "Test3";
            interviewsApp.UpdateJob(job);

            //ASSERT
            Assert.AreEqual("Test3", interviewsApp.GetJob(1).Name);
            Assert.AreEqual(2, interviewsApp.ListJobs().Count);
        }

        [TestMethod]
        public void DeleteJob()
        {
            //ARRANGE
            InterviewsApp interviewsApp = new InterviewsApp(
                new MockJobRepository(),
                new MockInterviewRepository()
                );
            interviewsApp.AddJob(new Job { Id = 1, Name = "Test1" });
            interviewsApp.AddJob(new Job { Id = 2, Name = "Test2" });

            //ACT
            var job = interviewsApp.GetJob(1);            
            interviewsApp.DeleteJob(job);

            //ASSERT            
            Assert.AreEqual(1, interviewsApp.ListJobs().Count);
            Assert.AreEqual("Test2", interviewsApp.GetJob(2).Name);
        }
    }
}
