using FamilyResearch.Data.DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyResearch.Data
{
    public class Repository : IDisposable
    {
        private DataContext _DataContext;

        public Repository()
        {
            _DataContext = new DataContext();
        }

        public void AddPerson(string firstName, string surName, DateTime dateOfBirth)
        {
            _DataContext.People.Add(new Person
            {
                FirstName = firstName,
                Surname = surName,
                DateOfBirth = dateOfBirth
            });

            _DataContext.SaveChanges();
        }

        public IEnumerable<IPerson> GetAll() => _DataContext.People;

        public void Dispose()
        {
            _DataContext.Dispose();
        }
    }
}
