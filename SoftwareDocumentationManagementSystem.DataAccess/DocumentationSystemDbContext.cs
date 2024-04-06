using Microsoft.EntityFrameworkCore;
using SoftwareDocumentationManagementSystem.DataAccess.Entity;

namespace SoftwareDocumentationManagementSystem.DataAccess;

public class DocumentationSystemDbContext : DbContext
{
    public DocumentationSystemDbContext(DbContextOptions<DocumentationSystemDbContext> options) : base(options)
    {
    }

    public DbSet<SoftwareEntity> Softwares { get; set; }
    public DbSet<ImageEntity> Images { get; set; }
    public DbSet<CodeBlockEntity> CodeBlocks { get; set; }
}