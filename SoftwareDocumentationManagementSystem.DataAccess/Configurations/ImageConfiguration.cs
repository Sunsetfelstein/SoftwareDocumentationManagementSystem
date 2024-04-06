using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SoftwareDocumentationManagementSystem.DataAccess.Entity;

namespace SoftwareDocumentationManagementSystem.DataAccess.Configurations;

public class ImageConfiguration : IEntityTypeConfiguration<ImageEntity>
{
    public void Configure(EntityTypeBuilder<ImageEntity> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Description).IsRequired();
        builder.Property(x => x.ImageData).IsRequired();
        builder.HasOne<SoftwareEntity>(x => x.Software)
            .WithMany(x => x.Images)
            .HasForeignKey(x => x.SoftwareId)
            .IsRequired();
        builder.HasOne<UserEntity>(x => x.Author)
            .WithMany(x => x.Images)
            .HasForeignKey(x => x.AuthorId)
            .IsRequired();
    }
}