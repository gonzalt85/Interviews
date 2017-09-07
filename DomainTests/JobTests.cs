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
            
            interviewsApp.AddJob(new Job { Id = 4, Name = "Test" });
            var retrievedJob =  interviewsApp.GetJob(4);

            Assert.AreEqual(4, retrievedJob.Id);
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
            
            Assert.AreEqual(5, interviewsApp.ListJobs().Count);
        }

        [TestMethod]
        public void UpdateJob()
        {
            //ARRANGE
            InterviewsApp interviewsApp = new InterviewsApp(
                new MockJobRepository(),
                new MockInterviewRepository()
                );
            interviewsApp.AddJob(new Job { Id = 4, Name = "Test1" });
            interviewsApp.AddJob(new Job { Id = 5, Name = "Test2" });

            //ACT
            var job = interviewsApp.GetJob(4);
            job.Name = "Test4";
            interviewsApp.UpdateJob(job);

            //ASSERT
            Assert.AreEqual("Test4", interviewsApp.GetJob(4).Name);
            Assert.AreEqual(5, interviewsApp.ListJobs().Count);
        }

        [TestMethod]
        public void DeleteJob()
        {
            //ARRANGE
            InterviewsApp interviewsApp = new InterviewsApp(
                new MockJobRepository(),
                new MockInterviewRepository()
                );
            interviewsApp.AddJob(new Job { Id = 4, Name = "Test1" });
            interviewsApp.AddJob(new Job { Id = 5, Name = "Test5" });

            //ACT
            var job = interviewsApp.GetJob(4);            
            interviewsApp.DeleteJob(job);

            //ASSERT            
            Assert.AreEqual(4, interviewsApp.ListJobs().Count);
            Assert.AreEqual("Test5", interviewsApp.GetJob(5).Name);
        }
    }
}
