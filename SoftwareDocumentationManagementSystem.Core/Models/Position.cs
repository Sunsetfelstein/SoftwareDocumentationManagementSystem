namespace SoftwareDocumentationManagementSystem.Core.Models;

public class Position
{
    public Position(Guid id, string name)
    {
        Id = id;
        Name = name;
    }
    
    public Guid Id { get; }
    public string Name { get; }
    public List<User> Users { get; } = new();
}