﻿using CSharpFunctionalExtensions;

namespace SoftwareDocumentationManagementSystem.Core.Models;

public class User
{
    private User(Guid id, string firstName, string secondName, string phoneNumber, string gitUrl, Position position, Guid positionId)
    {
        Id = id;
        FirstName = firstName;
        SecondName = secondName;
        PhoneNumber = phoneNumber;
        GitUrl = gitUrl;
        Position = position;
        PositionId = positionId;
    }
    public Guid Id { get; }
    public string FirstName { get; }
    public string SecondName { get; }
    public string PhoneNumber { get; }
    public string GitUrl { get; }
    public Position Position { get; }
    public Guid PositionId { get; }
    public List<Software> Softwares { get; } = new();
    public List<Image> Images { get; } = new();
    public List<CodeBlock> CodeBlocks { get; } = new();
    
    public static Result<User> Create(Guid id, string firstName, string secondName, string phoneNumber, string gitUrl, Position position, Guid positionId)
    {
        var user = new User(id, firstName, secondName, phoneNumber, gitUrl, position, positionId);

        return Result.Success(user);
    }
}