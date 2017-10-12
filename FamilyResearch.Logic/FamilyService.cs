using FamilyResearch.Data;
using FamilyResearch.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyResearch.Logic
{
    public class FamilyService: IDisposable
    {
        private Repository _Repository;

        public FamilyService()
        {
            _Repository = new Repository();
        }

        public IEnumerable<PersonModel> GetPeopleBySurname(string surname) 
            => _Repository.GetAll().Where(p => p.Surname.Equals(surname)).Select(model => new PersonModel(model));

        public void AddPerson(string firstName, string surname, DateTime dateOfBirth) 
            => _Repository.AddPerson(firstName, surname, dateOfBirth);

        public void Dispose()
        {
            _Repository.Dispose();
        }
    }
}
