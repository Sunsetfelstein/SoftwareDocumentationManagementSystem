namespace SoftwareDocumentationManagementSystem.Core.Models;

public class CodeBlock
{
    public CodeBlock(Guid id, Guid projectId, string code, string description)
    {
        Id = id;
        Code = code;
        Description = description;
        ProjectId = projectId;
    }

    public Guid Id { get; private set; }
    public Guid ProjectId { get; private set; }
    public string Code { get; set; }
    public string Description { get; set; }

}