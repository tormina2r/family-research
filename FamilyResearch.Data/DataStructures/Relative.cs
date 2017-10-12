using System.Collections.Generic;
using System.Data.Entity;

namespace FamilyResearch.Data.DataStructures
{
    public class Relative : IRelative
    {
        public int Id { get; set; }
        public Person Person { get; set; }
        public RelationType RelationType { get; set; }
        public DbSet<Documentation> Documentation { get; set; }

        IPerson IRelative.Person => Person;

        IEnumerable<IDocumentation> IRelative.Documentation => Documentation;
    }
}