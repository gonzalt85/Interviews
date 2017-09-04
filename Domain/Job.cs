using System;

namespace Interviews.Domain
{
    public class Job
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Entered { get; set; }
        public string Duration { get; set; }
        public string Status { get; set; }
        public string Requirements { get; set; }
        public string Notes { get; set; }
        public string Location { get; set; }
        public string Contacts { get; set; }
    }
}
