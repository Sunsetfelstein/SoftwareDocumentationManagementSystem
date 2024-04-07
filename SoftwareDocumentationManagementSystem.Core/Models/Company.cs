using CSharpFunctionalExtensions;

namespace SoftwareDocumentationManagementSystem.Core.Models;

public class Company
{
    private Company(Guid id, string name, string description, string address)
    {
        Id = id;
        Name = name;
        Description = description;
        Address = address;
    }
    public Guid Id { get; }
    public string Name { get; }
    public string Description { get; }
    public string Address { get; }
    public List<Software> Softwares { get; } = new();
    public static Result<Company> Create(Guid id, string name, string description, string address)
    {
        var company = new Company(id,  name, description, address);

        return Result.Success(company);
    }
}