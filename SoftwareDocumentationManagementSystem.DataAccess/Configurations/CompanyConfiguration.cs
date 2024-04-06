using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SoftwareDocumentationManagementSystem.DataAccess.Entity;

namespace SoftwareDocumentationManagementSystem.DataAccess.Configurations;

public class CompanyConfiguration : IEntityTypeConfiguration<CompanyEntity>
{
    public void Configure(EntityTypeBuilder<CompanyEntity> builder)
    {
        builder.HasKey(x => x.Id);
        builder.HasMany<SoftwareEntity>(x => x.Softwares)
            .WithOne(x => x.Company)
            .HasForeignKey(x => x.CompanyId)
            .IsRequired();
    }
}