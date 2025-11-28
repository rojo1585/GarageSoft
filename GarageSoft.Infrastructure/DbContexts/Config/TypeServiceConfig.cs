using GarageSoft.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GarageSoft.Infrastructure.DbContexts.Config;

public class TypeServiceConfig : IEntityTypeConfiguration<TypesService>
{
    public void Configure(EntityTypeBuilder<TypesService> builder)
    {
        builder.HasKey(e => e.Id).HasName("PK__TypesSer__3214EC07FD8095C3");

        builder.Property(e => e.Description).HasMaxLength(250);
        builder.Property(e => e.Name).HasMaxLength(100);
        builder.Property(e => e.RegistrationDate).HasDefaultValueSql("(getutcdate())");
        builder.Property(e => e.SuggestedPrice).HasColumnType("decimal(18, 2)");
    }
}
