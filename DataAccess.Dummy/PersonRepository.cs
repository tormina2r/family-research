using ServiceLayer.Persons;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Dummy
{
    public class PersonRepository : IPersonRepository
    {
        public IQueryable<IPersonEntity> GetAll()
        {
            return new List<IPersonEntity>
            {
                new Person{Id = 1, DateOfBirth = new DateTime(2000, 1, 1), FirstName = "Bruce", LastName = "Willis"},
                new Person{Id = 2, DateOfBirth = new DateTime(2010, 1, 1), FirstName = "Schwarzenegger", LastName = "Arnold"},
                new Person{Id = 3, DateOfBirth = new DateTime(2017, 1, 1), FirstName = "Stallone", LastName = "Sylvester"},
            }.AsQueryable();
        }

        public IPersonEntity GetById(int id)
        {
            return GetAll().FirstOrDefault();
        }

        public void Add(IPersonEntity entity)
        {
            
        }

        public void Remove(IPersonEntity entity)
        {
            
        }
    }
     
    class Person: IPersonEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
