using ServiceLayer.Persons;
using System.Collections.Generic;

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
        {
            return _PersonRepository.GetAll();
        }
    }
}
