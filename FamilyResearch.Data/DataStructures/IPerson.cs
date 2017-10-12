using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace FamilyResearch.Data.DataStructures
{
    public interface IPerson
    {
        int Id { get; }
        string FirstName { get; }
        string Surname { get; }
        DateTime DateOfBirth { get; }
        IEnumerable<IRelative> Relatives { get; }
    }
}