using CSharpFunctionalExtensions;

namespace SoftwareDocumentationManagementSystem.Core.Models;

public class CodeBlock
{
    public CodeBlock(Guid id, Guid projectId, Guid authorId, User author, Software software, Guid softwareId, string code, string description)
    {
        Id = id;
        Code = code;
        Description = description;
        Software = software;
        SoftwareId = softwareId;
        ProjectId = projectId;
        Author = author;
        AuthorId = authorId;
    }

    public Guid Id { get; }
    public Guid ProjectId { get; }
    public Guid SoftwareId { get; }
    public Software Software { get; }
    public User Author { get; }
    public Guid AuthorId { get; }
    public string Code { get; }
    public string Description { get; }

    public Result<CodeBlock> Create(Guid id, Guid projectId, Guid authorId, User author, Software software,
        Guid softwareId, string code, string description)
    {
        var codeBlock = new CodeBlock(id, projectId, authorId, author, software, softwareId, code, description);

        return Result.Success(codeBlock);
    }
}