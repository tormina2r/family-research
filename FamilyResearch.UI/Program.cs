using FamilyResearch.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyResearch.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var familyService = new FamilyService())
            {
                //familyService.AddPerson("Dolly", "Duck", DateTime.Today.AddYears(-100));
                var people = familyService.GetPeopleBySurname("Duck");
                foreach (var person in people)
                {
                    Console.WriteLine(person);
                }

                Console.ReadKey();
            }
        }
    }
}
