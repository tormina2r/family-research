using ServiceLayer.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer.Persons
{
    public class PersonEntity : IEntity
    {
        public int Id { get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
