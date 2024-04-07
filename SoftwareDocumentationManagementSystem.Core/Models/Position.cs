using CSharpFunctionalExtensions;

namespace SoftwareDocumentationManagementSystem.Core.Models;

public class Position
{
    private Position(Guid id, string name)
    {
        Id = id;
        Name = name;
    }
    
    public Guid Id { get; }
    public string Name { get; }
    public List<User> Users { get; } = new();
    
    public static Result<Position> Create(Guid id, string name)
    {
        var position = new Position(id, name);

        return Result.Success(position);
    }
}