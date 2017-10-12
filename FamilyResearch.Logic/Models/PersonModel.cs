using FamilyResearch.Data.DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyResearch.Logic.Models
{
    public class PersonModel
    {
        private IPerson _Model;

        public PersonModel(IPerson model)
        {
            _Model = model;
        }

        public string FullName => $"{_Model.Surname}, {_Model.FirstName}";

        public override string ToString() => FullName;
    }
}
