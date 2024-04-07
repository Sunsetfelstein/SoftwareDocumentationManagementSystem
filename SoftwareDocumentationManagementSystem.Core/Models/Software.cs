using CSharpFunctionalExtensions;

namespace SoftwareDocumentationManagementSystem.Core.Models;

public class Software
{
    public const int MAX_TITLE_LENGTH = 100;
    private Software(Guid id, Guid authorId, User author, Guid companyId, Company company, bool isPublic, string title, string description, string gitUrl)
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
    
    public List<Image> Images { get; } = new();
    public List<CodeBlock> CodeBlocks { get;} = new();

    public static Result<Software> Create(Guid id, Guid authorId, User author, Guid companyId, Company company, bool isPublic, string title, string description, string gitUrl)
    {
        if (string.IsNullOrEmpty(title) || title.Length > MAX_TITLE_LENGTH)
        {
            return Result.Failure<Software>(
                $"'{nameof(title)}' не может быть пустым или длиннее {MAX_TITLE_LENGTH} символов");
        }

        var software = new Software(id, authorId, author, companyId, company, isPublic, title, description, gitUrl);

        return Result.Success(software);
    }
}