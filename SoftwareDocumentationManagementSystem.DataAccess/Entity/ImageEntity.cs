namespace SoftwareDocumentationManagementSystem.DataAccess.Entity;

public class ImageEntity
{
    public ImageEntity(Guid id, Guid softwareId, string description, byte[] imageData)
    {
        Id = id;
        SoftwareId = softwareId;
        Description = description;
        ImageData = imageData;
    }

    public Guid Id { get; set; }
    public Guid SoftwareId { get; set; }
    public SoftwareEntity Software { get; set; }
    public string Description { get; set; }
    public byte[] ImageData { get; set; }
}