using System;
using ServiceLayer.Common;

namespace ServiceLayer.Persons
{
    public interface IPerson : IEntity
    {
        string FirstName { get; }
        string LastName { get; }
        DateTime DateOfBirth { get; }
    }
}