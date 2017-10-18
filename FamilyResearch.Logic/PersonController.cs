using FamilyResearch.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyResearch.BusinessLogic
{
    internal class PersonController: IPersonController
    {
        private IPersonRepository _PersonRepository;

        public PersonController(IPersonRepository personRepository)
        {
            _PersonRepository = personRepository;
            People.AddRange(personRepository.List().Select(entity => new PersonDisplay(entity)));
        }

        public List<PersonDisplay> People { get; } = new List<PersonDisplay>();
    }
}
