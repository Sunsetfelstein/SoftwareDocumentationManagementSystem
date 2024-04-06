namespace SoftwareDocumentationManagementSystem.Core.Models;

public class Image
{
    public Image(Guid id, Guid projectId, Software software, string description, byte[] imageData)
    {
        Id = id;
        ProjectId = projectId;
        Software = software;
        Description = description;
        ImageData = imageData;
    }

    public Guid Id { get; }
    public Guid ProjectId { get; }
    public Software Software { get;}
    public string Description { get; set; }
    public byte[] ImageData { get; private set; }
}