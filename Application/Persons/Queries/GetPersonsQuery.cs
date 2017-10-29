using Domain.Persons;
using ServiceLayer.Persons;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Application.Persons.Queries
{
    public class GetPersonsQuery : IGetPersonsQuery
    {
        private readonly IPersonRepository _PersonRepository;

        public IEnumerable<IPerson> Query()
        {
            return _PersonRepository.GetAll().Select(CreatePerson);

        }

        private IPerson CreatePerson(PersonEntity entity)
        {
            return new Person
            {
                FirstName = entity.FirstName,
                LastName = entity.LastName,
                DateOfBirth = entity.DateOfBirth
            };
        }
    }
}
