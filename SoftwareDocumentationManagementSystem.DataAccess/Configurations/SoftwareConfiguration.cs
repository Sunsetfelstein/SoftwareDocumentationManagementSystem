using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SoftwareDocumentationManagementSystem.DataAccess.Entity;

namespace SoftwareDocumentationManagementSystem.DataAccess.Configurations;

public class SoftwareConfiguration : IEntityTypeConfiguration<SoftwareEntity>
{
    public void Configure(EntityTypeBuilder<SoftwareEntity> builder)
    {
        
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Title).IsRequired();
        builder.Property(x => x.Description).IsRequired();
        builder.Property(x => x.GitUrl).IsRequired();
        builder.HasMany<CodeBlockEntity>(x => x.CodeBlocks)
            .WithOne(x => x.Software)
            .HasForeignKey(x => x.SoftwareId).IsRequired();
        builder.HasMany<ImageEntity>(x => x.Images)
            .WithOne(x => x.Software)
            .HasForeignKey(x => x.SoftwareId).IsRequired();
    }
}