using System.Collections.Generic;
using ServiceLayer.Persons;

namespace Application.Persons.Queries
{
    public interface IGetPersonsQuery
    {
        IEnumerable<IPerson> Query();
    }
}
