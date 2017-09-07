using System;
using System.Collections.Generic;
using System.Text;

namespace Interviews.Common.Interfaces
{
    public interface ICRUD<T>
    {
        void Add(T item);
        T Get(int id);
        List<T> List();
        void Update(T item);
        void Delete(T item);
    }
}
