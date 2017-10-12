namespace FamilyResearch.Data.DataStructures
{
    public class Attachment : IAttachment
    {
        public int Id { get; set; }
        public AttachmentType Type { get; set; }
        public byte[] Data { get; set; }
    }
}