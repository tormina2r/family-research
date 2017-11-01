using System;
using ServiceLayer.Persons;

namespace Presentation.Mvc.Models
{
    public class PersonModel
    {
        private readonly IPerson _Model;

        public PersonModel(IPerson model)
        {
            _Model = model;
        }

        public string FullName => $"{_Model.LastName}, {_Model.FirstName}";

        public DateTime DateOfBirth => _Model.DateOfBirth;
    }
}