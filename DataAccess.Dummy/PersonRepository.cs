using ServiceLayer.Persons;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Dummy
{
    public class PersonRepository : IPersonRepository
    {
        public void Add(PersonEntity entity)
        {
            //Do nothing
        }

        public IQueryable<PersonEntity> GetAll()
        {
            return new List<PersonEntity>
            {
                new PersonEntity
                {
                    Id = 1,
                    FirstName = "Hello",
                    LastName = "World",
                    DateOfBirth = DateTime.Today
                },
                    new PersonEntity
                {
                    Id = 2,
                    FirstName = "Hello2",
                    LastName = "World2",
                    DateOfBirth = DateTime.Today.AddDays(-1)
                }
            }.AsQueryable();
        }

        public PersonEntity GetById(int id)
        {
            return new PersonEntity
            {
                Id = 1,
                FirstName = "Hello",
                LastName = "World",
                DateOfBirth = DateTime.Today
            };
        }

        public void Remove(PersonEntity entity)
        {
            //Do nothing
        }
    }
}
