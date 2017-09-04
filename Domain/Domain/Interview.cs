using System;

namespace Interviews
{
    public class Interview
    {
        public int Id { get; set; }
        public DateTime ScheduledDate { get; set; }
        public DateTime TakenOn { get; set; }
        public string Interviewer { get; set; }
        public int Job { get; set; }
        public int InterviewType { get; set; }
    }
}