using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SoftwareDocumentationManagementSystem.DataAccess.Entity;

namespace SoftwareDocumentationManagementSystem.DataAccess.Configurations;

public class PositionConfigure : IEntityTypeConfiguration<PositionEntity>
{
    public void Configure(EntityTypeBuilder<PositionEntity> builder)
    {
        builder.HasKey(x => x.Id);
        builder.HasMany<UserEntity>(x => x.Users)
            .WithOne(x => x.Position)
            .HasForeignKey(x => x.PositionId)
            .IsRequired();
    }
}