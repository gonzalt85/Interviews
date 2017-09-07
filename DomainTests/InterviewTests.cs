using Microsoft.VisualStudio.TestTools.UnitTesting;
using Interviews.Domain;
using Interviews.Application;
using Interviews.Repository;

namespace DomainTests
{
    [TestClass]
    public class InterviewsTests
    {
        [TestMethod]
        public void CreateAndGetInterview()
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
        public void GetListOfInterviews()
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
        public void UpdateInterview()
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
        public void DeleteInterview()
        {
            //ARRANGE
            InterviewsApp interviewsApp = new InterviewsApp(
                new MockJobRepository(),
                new MockInterviewRepository()
                );
            interviewsApp.AddInterview(new Interview { Id = 1 });
            interviewsApp.AddInterview(new Interview { Id = 2 });

            //ACT
            var interview = interviewsApp.GetInterview(1);            
            interviewsApp.DeleteInterview(interview);

            //ASSERT            
            Assert.AreEqual(1, interviewsApp.ListInterviews().Count);
            Assert.AreEqual(2, interviewsApp.GetInterview(2).Id);
        }
    }
}
