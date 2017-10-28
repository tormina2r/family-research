using Domain.Persons;
using ServiceLayer.Persons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Application.Persons.Queries
{
    public interface IGetPersonsQuery
    {
        IEnumerable<IPerson> Query();
    }

    public class GetPersonsQuery : IGetPersonsQuery
    {
        private readonly IPersonsRepository _PersonRepository;

        public IEnumerable<IPerson> Query()
        {
            return _PersonRepository.GetAll().Select(CreatePerson);

        }

        private IPerson CreatePerson(PersonEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
