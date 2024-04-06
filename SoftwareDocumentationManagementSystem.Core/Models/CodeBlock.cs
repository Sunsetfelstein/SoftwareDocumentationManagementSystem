namespace SoftwareDocumentationManagementSystem.Core.Models;

public class CodeBlock
{
    public CodeBlock(Guid id, Guid projectId, Software software, string code, string description)
    {
        Id = id;
        Code = code;
        Description = description;
        Software = software;
        ProjectId = projectId;
    }

    public Guid Id { get; }
    public Guid ProjectId { get; }
    public Software Software { get; set; }
    public string Code { get; set; }
    public string Description { get; set; }

}