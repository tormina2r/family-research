using FamilyResearch.Data.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyResearch.Data.EF
{
    internal class PersonRepository : IPersonRepository
    {
        DataContext _DataContext = new DataContext();

        public void Add(PersonEntity entity)
        {
            _DataContext.People.Add(entity);
            _DataContext.SaveChanges();
        }

        public void Delete(PersonEntity entity)
        {
            _DataContext.People.Remove(entity);
            _DataContext.SaveChanges();
        }

        public void Edit(PersonEntity entity) => _DataContext.SaveChanges();

        public PersonEntity Get(int id) => _DataContext.People.Single(person => person.Id == id);

        public IEnumerable<PersonEntity> List() => _DataContext.People;

        public void Dispose() => _DataContext.Dispose();
    }
}
