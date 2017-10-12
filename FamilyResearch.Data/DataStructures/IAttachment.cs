namespace FamilyResearch.Data.DataStructures
{
    public interface IAttachment
    {
        int Id { get; }
        AttachmentType Type { get; }
        byte[] Data { get; }
    }
}