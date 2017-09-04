using System;

namespace Interviews.Domain
{
    public class Interview
    {
        public int Id { get; set; }
        public DateTime ScheduledDate { get; set; }
        public DateTime TakenOn { get; set; }
        public string Interviewer { get; set; }
        public Job Job { get; set; }
        public int InterviewType { get; set; }
    }
}