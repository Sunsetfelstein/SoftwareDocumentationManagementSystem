using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SoftwareDocumentationManagementSystem.DataAccess.Entity;

namespace SoftwareDocumentationManagementSystem.DataAccess.Configurations;

public class CodeBlockConfiguration : IEntityTypeConfiguration<CodeBlockEntity>
{
    public void Configure(EntityTypeBuilder<CodeBlockEntity> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Code).IsRequired();
        builder.Property(x => x.Description).IsRequired();
        builder.HasOne<SoftwareEntity>(x => x.Software)
            .WithMany(x => x.CodeBlocks)
            .HasForeignKey(x => x.SoftwareId)
            .IsRequired();
        builder.HasOne<UserEntity>(x => x.Author)
            .WithMany(x => x.CodeBlocks)
            .HasForeignKey(x => x.AuthorId)
            .IsRequired();
    }
}