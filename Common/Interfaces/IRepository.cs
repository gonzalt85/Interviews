using System;
using System.Collections.Generic;
using System.Text;

namespace Interviews.Common.Interfaces
{
    public interface IRepository<T>
    {
        void Add(T item);
        T Get(int id);
        void Update(T item);
        void Delete(int id);
    }
}
