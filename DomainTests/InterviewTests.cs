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
            
            interviewsApp.AddInterview(new Interview { Id = 4 });
            var retrievedInterview =  interviewsApp.GetInterview(1);

            Assert.AreEqual(1, retrievedInterview.Id);            
        }

        [TestMethod]
        public void GetListOfInterviews()
        {

            InterviewsApp interviewsApp = new InterviewsApp(
                new MockJobRepository(),
                new MockInterviewRepository()
                );
            
            Assert.AreEqual(3, interviewsApp.ListInterviews().Count);            
        }

        [TestMethod]
        public void UpdateInterview()
        {
            //ARRANGE
            InterviewsApp interviewsApp = new InterviewsApp(
                new MockJobRepository(),
                new MockInterviewRepository()
                );
            interviewsApp.AddInterview(new Interview { Id = 4 });
            interviewsApp.AddInterview(new Interview { Id = 5 });

            //ACT
            var interview = interviewsApp.GetInterview(4);
            interview.Id = 6;
            interviewsApp.UpdateInterview(interview);

            //ASSERT
            Assert.AreEqual(6, interviewsApp.GetInterview(6).Id);
            Assert.AreEqual(5, interviewsApp.ListInterviews().Count);
        }

        [TestMethod]
        public void DeleteInterview()
        {
            //ARRANGE
            InterviewsApp interviewsApp = new InterviewsApp(
                new MockJobRepository(),
                new MockInterviewRepository()
                );
            interviewsApp.AddInterview(new Interview { Id = 4 });
            interviewsApp.AddInterview(new Interview { Id = 5 });

            //ACT
            var interview = interviewsApp.GetInterview(1);         
            interviewsApp.DeleteInterview(interview);

            //ASSERT            
            Assert.AreEqual(4, interviewsApp.ListInterviews().Count);
            Assert.AreEqual(2, interviewsApp.GetInterview(2).Id);
        }
    }
}
