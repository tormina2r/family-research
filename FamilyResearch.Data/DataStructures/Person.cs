using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyResearch.Data.DataStructures
{
    public class Person : IPerson
    {
        public int Id { get; set; }
        public string Surname { get; set; }
        public string FirstName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DbSet<Relative> Relatives { get; set; }
        IEnumerable<IRelative> IPerson.Relatives => Relatives;
    }
}
