using ServiceLayer.Persons;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Dummy
{
    public class PersonRepository : IPersonRepository
    {
        public IQueryable<IPerson> GetAll()
        {
            return new List<IPerson>
            {
                new Person{Id = 1, DateOfBirth = new DateTime(2000, 1, 1), FirstName = "Hello", LastName = "World!"},
                new Person{Id = 2, DateOfBirth = new DateTime(2010, 1, 1), FirstName = "Hi", LastName = "World!"},
                new Person{Id = 3, DateOfBirth = new DateTime(2017, 1, 1), FirstName = "Wazup", LastName = "World!"},
            }.AsQueryable();
        }

        public IPerson GetById(int id)
        {
            return new Person
            {
                Id = 1,
                DateOfBirth = new DateTime(2000, 1, 1),
                FirstName = "Hello",
                LastName = "World!"
            };
        }

        public void Add(IPerson entity)
        {
            
        }

        public void Remove(IPerson entity)
        {
            
        }
    }
     
    class Person: IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
