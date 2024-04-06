namespace SoftwareDocumentationManagementSystem.DataAccess.Entity;

public class UserEntity
{
    public UserEntity(Guid id, string firstName, string secondName, string phoneNumber, string gitUrl, PositionEntity position, Guid positionId)
    {
        Id = id;
        FirstName = firstName;
        SecondName = secondName;
        PhoneNumber = phoneNumber;
        GitUrl = gitUrl;
        Position = position;
        PositionId = positionId;
    }
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string SecondName { get; set; }
    public string PhoneNumber { get; set; }
    public string GitUrl { get; set; }
    public PositionEntity Position { get; set; }
    public Guid PositionId { get; set; }
    public List<SoftwareEntity> Softwares { get; } = new();
    public List<CodeBlockEntity> CodeBlocks { get; } = new();
    public List<ImageEntity> Images { get; } = new();
}