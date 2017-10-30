using ServiceLayer.Persons;
using System.Collections.Generic;
using System.Linq;
using Domain.Persons;

namespace Application.Persons.Queries
{
    public class GetPersonsQuery : IGetPersonsQuery
    {
        private readonly IPersonRepository _PersonRepository;

        public GetPersonsQuery(IPersonRepository personRepository)
        {
            _PersonRepository = personRepository;
        }

        public IEnumerable<IPerson> Query() 
            => _PersonRepository.GetAll().Select(entity => new Person(entity));
    }
}
