using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SoftwareDocumentationManagementSystem.DataAccess.Entity;

namespace SoftwareDocumentationManagementSystem.DataAccess.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<UserEntity>
{
    public void Configure(EntityTypeBuilder<UserEntity> builder)
    {
        builder.HasKey(x => x.Id);
        builder.HasMany<SoftwareEntity>(x => x.Softwares)
            .WithOne(x => x.Author)
            .HasForeignKey(x => x.AuthorId)
            .IsRequired();
        builder.HasMany<CodeBlockEntity>(x => x.CodeBlocks)
            .WithOne(x => x.Author)
            .HasForeignKey(x => x.AuthorId)
            .IsRequired();
        builder.HasMany<ImageEntity>(x => x.Images)
            .WithOne(x => x.Author)
            .HasForeignKey(x => x.AuthorId)
            .IsRequired();
        builder.HasOne<PositionEntity>(x => x.Position)
            .WithMany(x => x.Users)
            .HasForeignKey(x => x.PositionId)
            .IsRequired();
    }
}