using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Persons
{
    public class Person: IPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
