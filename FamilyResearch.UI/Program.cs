using FamilyResearch.Data;
using FamilyResearch.Data.DataStructures;
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
            using (var repository = new Repository())
            {
                Console.WriteLine("List of people:");
                var people = repository.GetAllPeople();
                foreach (var person in people)
                {
                    Console.WriteLine(person);
                }
            }
        }
    }
}
