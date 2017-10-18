using FamilyResearch.Data.EF.Entities;

namespace FamilyResearch.BusinessLogic
{
    public class PersonDisplay
    {
        private readonly PersonEntity _Model;

        public PersonDisplay(PersonEntity model)
        {
            _Model = model;
        }

        public string FullName => $"{_Model.LastName}, {_Model.FirstName}";
    }
}