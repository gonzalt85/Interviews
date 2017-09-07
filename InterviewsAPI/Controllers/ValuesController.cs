using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Interviews.Application;
using Interviews.Common.Interfaces;
using Interviews.Domain;

namespace InterviewsAPI.Controllers
{
    [Route("api/[controller]")]
    public class JobController : Controller
    {
        private readonly InterviewsApp _interviewsApp;
        public JobController(IJobRepository jobRepository, IInterviewRepository interviewRepository)
        {
            _interviewsApp = new InterviewsApp(
                jobRepository, interviewRepository
                );
        }
        // GET api/values
        [HttpGet]
        public IEnumerable<Job> Get()
        {
            return _interviewsApp.ListJobs();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
