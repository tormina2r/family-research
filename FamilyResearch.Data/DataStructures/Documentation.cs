using System.Collections.Generic;
using System.Data.Entity;

namespace FamilyResearch.Data.DataStructures
{
    public class Documentation : IDocumentation
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DbSet<Attachment> Attachments { get; set; }

        IEnumerable<IAttachment> IDocumentation.Attachments => Attachments;
    }
}