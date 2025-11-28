using GarageSoft.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GarageSoft.Infrastructure.DbContexts.Config;

public class VehicleConfig : IEntityTypeConfiguration<Vehicle>
{
    public void Configure(EntityTypeBuilder<Vehicle> builder)
    {
        builder.HasKey(e => e.Id).HasName("PK__Vehicles__3214EC07A12DF0E7");

        builder.Property(e => e.Id).HasDefaultValueSql("(newid())");
        builder.Property(e => e.Brand).HasMaxLength(50);
        builder.Property(e => e.Color).HasMaxLength(30);
        builder.Property(e => e.FechaRegistro).HasDefaultValueSql("(getutcdate())");
        builder.Property(e => e.LicensePlate).HasMaxLength(20);
        builder.Property(e => e.Model).HasMaxLength(50);
        builder.Property(e => e.Vin).HasMaxLength(50);

        builder.HasOne(d => d.Client).WithMany(p => p.Vehicles)
            .HasForeignKey(d => d.ClientId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_Vehiculos_Clientes");
    }
}
