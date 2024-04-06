namespace SoftwareDocumentationManagementSystem.Core.Models;

public class Software
{
    public Software(Guid id, Guid authorId, User author, Guid companyId, Company company, bool isPublic, string title, string description, string gitUrl, string text)
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

    public Guid Id { get; }
    public Guid AuthorId { get; }
    public User Author { get; }
    public Company Company { get; }
    public Guid CompanyId { get; }
    public bool IsPublic { get; }
    public string Title { get; }
    public string Description { get; }
    public string GitUrl { get; }
    public string Text { get; }
    
    public List<Image> Images { get; } = new();
    public List<CodeBlock> CodeBlocks { get;} = new();
}