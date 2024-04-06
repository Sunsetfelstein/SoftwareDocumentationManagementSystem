namespace SoftwareDocumentationManagementSystem.Core.Models;

public class Image
{
    public Image(Guid id, Guid projectId, string description, byte[] imageData)
    {
        Id = id;
        ProjectId = projectId;
        Description = description;
        ImageData = imageData;
    }

    public Guid Id { get; private set; }
    public Guid ProjectId { get; private set; }
    public string Description { get; set; }
    public byte[] ImageData { get; private set; }
}