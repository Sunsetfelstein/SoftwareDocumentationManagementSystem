namespace SoftwareDocumentationManagementSystem.DataAccess.Entity;

public class CodeBlockEntity
{
    public CodeBlockEntity(Guid id, Guid projectId, Guid authorId, UserEntity author, SoftwareEntity software, string code, string description)
    {
        Id = id;
        Code = code;
        Description = description;
        Software = software;
        ProjectId = projectId;
        Author = author;
        AuthorId = authorId;
    }

    public Guid Id { get; set; }
    public Guid ProjectId { get; set; }
    public SoftwareEntity Software { get; set; }
    public Guid SoftwareId { get; set; }
    public UserEntity Author { get; set; }
    public Guid AuthorId { get; set; }
    public string Code { get; set; }
    public string Description { get; set; }
}