using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Persons
{
    public interface IPerson
    {
        string FirstName { get; }
        string LastName { get; }
        DateTime DateOfBirth { get; }
    }
}
