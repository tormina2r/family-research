using ServiceLayer.Persons;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Persons
{
    public class Person : IPerson
    {
        private readonly PersonEntity _Entity;

        public string FirstName => _Entity.FirstName;

        public string LastName => _Entity.LastName;

        public DateTime DateOfBirth => _Entity.DateOfBirth;
    }
}
