using System;
using ServiceLayer.Common;

namespace ServiceLayer.Persons
{
    public interface IPersonEntity : IEntity
    {
        string FirstName { get; }
        string LastName { get; }
        DateTime DateOfBirth { get; }
    }
}