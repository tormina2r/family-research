using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyResearch.Data
{
    public interface IRepository<T>
    {
        void Add(T entity);
        IEnumerable<T> List();
        T Get(int id);
        void Delete(T entity);
    }   
}
