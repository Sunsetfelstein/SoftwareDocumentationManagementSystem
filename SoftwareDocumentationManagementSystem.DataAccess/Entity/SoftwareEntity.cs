namespace SoftwareDocumentationManagementSystem.DataAccess.Entity;

public class SoftwareEntity
{
    public SoftwareEntity(Guid id, Guid authorId, UserEntity author, Guid companyId, CompanyEntity company, bool isPublic, string title, string description, string gitUrl, string text)
    {
        Id = id;
        Author = author;
        AuthorId = authorId;
        Company = company;
        CompanyId = companyId;
        IsPublic = isPublic;
        Title = title;
        Description = description;
        GitUrl = gitUrl;
        Text = text;
    }

    public Guid Id { get; set; }
    public Guid AuthorId { get; set; }
    public UserEntity Author { get; set; }
    public CompanyEntity Company { get; set; }
    public Guid CompanyId { get; set; }
    public bool IsPublic { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string GitUrl { get; set; }
    public string Text { get; set; }
    
    public List<ImageEntity> Images { get; set; } = new();
    public List<CodeBlockEntity> CodeBlocks { get; set; } = new();
    
}