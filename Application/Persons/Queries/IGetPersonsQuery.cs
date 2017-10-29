using Domain.Persons;
using System.Collections.Generic;
using System.Text;

namespace Application.Persons.Queries
{
    public interface IGetPersonsQuery
    {
        IEnumerable<IPerson> Query();
    }
}
