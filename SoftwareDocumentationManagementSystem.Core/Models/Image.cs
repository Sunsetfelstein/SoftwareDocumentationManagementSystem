using CSharpFunctionalExtensions;

namespace SoftwareDocumentationManagementSystem.Core.Models;

public class Image
{
    private Image(Guid id, Guid softwareId, Software software, Guid authorId, User author, string description, byte[] imageData)
    {
        Id = id;
        SoftwareId = softwareId;
        Software = software;
        AuthorId = authorId;
        Author = author;
        Description = description;
        ImageData = imageData;
    }

    public Guid Id { get; }
    public Guid SoftwareId { get; }
    public Software Software { get;}
    public User Author { get; }
    public Guid AuthorId { get; }
    public string Description { get; }
    public byte[] ImageData { get; }
    
    public static Result<Image> Create(Guid id, Guid softwareId, Software software, Guid authorId, User author, string description, byte[] imageData)
    {
        var image = new Image(id, softwareId, software, authorId, author, description, imageData);

        return Result.Success(image);
    }
}