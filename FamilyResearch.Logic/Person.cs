using FamilyResearch.Data;
using FamilyResearch.Data.EF.Entities;

namespace FamilyResearch.BusinessLogic
{
    public class PersonDisplay
    {
        private readonly IPerson _Model;

        public PersonDisplay(IPerson model)
        {
            _Model = model;
        }

        public string FullName => $"{_Model.LastName}, {_Model.FirstName}";
    }
}