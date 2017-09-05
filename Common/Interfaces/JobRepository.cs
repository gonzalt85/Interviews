using Interviews.Domain;

namespace Interviews.Common.Interfaces
{
    public interface JobRepository
    {
        void Add(Job newJob);       
        Job Get(int id);
    }
}
