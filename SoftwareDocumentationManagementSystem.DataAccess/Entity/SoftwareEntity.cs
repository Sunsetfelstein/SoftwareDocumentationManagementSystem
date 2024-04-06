namespace SoftwareDocumentationManagementSystem.DataAccess.Entity;

public class SoftwareEntity
{
    public SoftwareEntity(Guid id, Guid authorId, string title, string description, string gitUrl, string text)
    {
        Title = title;
        Description = description;
        GitUrl = gitUrl;
        Text = text;
    }
    
    public Guid Id { get; set; }
    public Guid AuthorId { get; set; }
    public bool IsPublic { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string GitUrl { get; set; }
    public string Text { get; set; }
    
    public List<ImageEntity> Images { get; set; } = new();
    public List<CodeBlockEntity> CodeBlocks { get; set; } = new();
    
}