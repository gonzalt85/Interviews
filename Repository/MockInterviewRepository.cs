using System;
using Interviews.Common.Interfaces;
using System.Collections.Generic;
using Interviews.Domain;

namespace Interviews.Repository
{
    public class MockInterviewRepository : IInterviewRepository
    {
        private List<Interview> _interviews = new List<Interview>() {
            new Interview { Id=1 },
            new Interview { Id=2 },
            new Interview { Id=3 },
        };              

        public void Add(Interview interview)
        {
            _interviews.Add(interview);
        }

        public void Delete(Interview interview)
        {
            _interviews.Remove(interview);
        }

        public Interview Get(int id)
        {
            return _interviews.Find(i => i.Id == id);
        }

        public List<Interview> List()
        {
            return _interviews;
        }

        public void Update(Interview interview)
        {
            _interviews.Remove(interview);
            _interviews.Add(interview);
        }       
    }
}
