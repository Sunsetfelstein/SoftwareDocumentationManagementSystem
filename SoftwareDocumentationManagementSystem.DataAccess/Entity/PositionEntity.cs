namespace SoftwareDocumentationManagementSystem.DataAccess.Entity;

public class PositionEntity
{
    PositionEntity(Guid id, string name)
    {
        Id = id;
        Name = name;
    }
    
    public Guid Id { get; set; }
    public string Name { get; set; }
    public List<UserEntity> Users { get; set; }
}