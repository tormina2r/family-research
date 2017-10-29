using ServiceLayer.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServiceLayer.Persons
{
    public interface IPersonRepository: IRepository<PersonEntity>
    {
    }    
}
