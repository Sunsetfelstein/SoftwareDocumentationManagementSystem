namespace SoftwareDocumentationManagementSystem.DataAccess.Entity;

public class CodeBlockEntity
{
    public CodeBlockEntity(Guid id, Guid softwareId, SoftwareEntity software, string code, string description)
    {
        Id = id;
        Code = code;
        Software = software;
        Description = description;
        SoftwareId = softwareId;
    }

    public Guid Id { get; set; }
    public Guid SoftwareId { get; set; }
    public SoftwareEntity Software { get; set; }
    public string Code { get; set; }
    public string Description { get; set; }
}