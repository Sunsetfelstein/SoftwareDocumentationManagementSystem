namespace SoftwareDocumentationManagementSystem.DataAccess.Entity;

public class ImageEntity
{
    public ImageEntity(Guid id, Guid softwareId, SoftwareEntity software, Guid authorId, UserEntity author, string description, byte[] imageData)
    {
        Id = id;
        SoftwareId = softwareId;
        Software = software;
        AuthorId = authorId;
        Author = author;
        Description = description;
        ImageData = imageData;
    }

    public Guid Id { get; set; }
    public Guid SoftwareId { get; set; }
    public SoftwareEntity Software { get; set; }
    public UserEntity Author { get; set; }
    public Guid AuthorId { get; set; }
    public string Description { get; set; }
    public byte[] ImageData { get; set; }
}