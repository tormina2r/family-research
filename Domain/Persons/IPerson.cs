using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Persons
{
    public interface IPerson
    {
        string FirstName { get; }
        string LastName { get; }
        DateTime DateOfBirth { get; }
    }
}
