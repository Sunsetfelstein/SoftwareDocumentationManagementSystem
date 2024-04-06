namespace SoftwareDocumentationManagementSystem.DataAccess.Entity;

public class CompanyEntity
{
    public CompanyEntity(Guid id, string name, string description, string address)
    {
        Id = id;
        Name = name;
        Description = description;
        Address = address;
    }
    public Guid Id { get; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Address { get; set; }
    public List<SoftwareEntity> Softwares { get; } = new();
}