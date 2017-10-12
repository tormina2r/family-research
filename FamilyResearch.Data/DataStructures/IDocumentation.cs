using System.Collections.Generic;
using System.Data.Entity;

namespace FamilyResearch.Data.DataStructures
{
    public interface IDocumentation
    {
        int Id { get; }
        string Title { get; }
        string Description { get; }
        IEnumerable<IAttachment> Attachments { get; }
    }
}