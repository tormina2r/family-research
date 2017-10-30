using System;
using ServiceLayer.Persons;

namespace Domain.Persons
{
    public class Person: IPerson
    {
        public Person(IPersonEntity entity)
        {
            Id = entity.Id;
            FirstName = entity.FirstName;
            LastName = entity.LastName;
            DateOfBirth = entity.DateOfBirth;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
