using System.Collections.Generic;
using System.Data.Entity;

namespace FamilyResearch.Data.DataStructures
{
    public interface IRelative
    {
        int Id { get; }
        IPerson Person { get; }
        RelationType RelationType { get; set; }
        IEnumerable<IDocumentation> Documentation { get; }
    }
}