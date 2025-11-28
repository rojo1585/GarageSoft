using GarageSoft.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GarageSoft.Infrastructure.DbContexts.Config;

public class ClientConfig : IEntityTypeConfiguration<Client>
{
    public void Configure(EntityTypeBuilder<Client> builder)
    {
        builder.HasKey(e => e.Id).HasName("PK__Clients__3214EC076BDBF83F");

        builder.Property(e => e.Id).HasDefaultValueSql("(newid())");
        builder.Property(e => e.Email).HasMaxLength(100);
        builder.Property(e => e.Name).HasMaxLength(100);
        builder.Property(e => e.Phone).HasMaxLength(10);
        builder.Property(e => e.RegistrationDate).HasDefaultValueSql("(getutcdate())");
    }
}
