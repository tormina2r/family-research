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
        public void Add(IPerson entity)
        {
            var personEntity = CreatePersonEntity(entity);

            using (var dataContext = new DataContext())
            {
                dataContext.People.Add(personEntity);
                dataContext.SaveChanges();                
            }
        }

        private PersonEntity CreatePersonEntity(IPerson entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(IPerson entity)
        {
            using (var dataContext = new DataContext())
            {
                var personEntity = dataContext.People.Single(p => p.Id == entity.Id);
                dataContext.People.Remove(personEntity);
                dataContext.SaveChanges();
            }
        }

        public IPerson Get(int id)
        {
            using (var dataContext = new DataContext())
            {
                var personEntity = dataContext.People.Single(person => person.Id == id);
                return personEntity;
            }
        }

        public IEnumerable<IPerson> List()
        {
            using (var dataContext = new DataContext())
                return dataContext.People.ToList();
        }
    }
}
