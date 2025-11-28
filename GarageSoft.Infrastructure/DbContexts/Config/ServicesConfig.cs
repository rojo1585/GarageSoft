using GarageSoft.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GarageSoft.Infrastructure.DbContexts.Config;

public class ServicesConfig : IEntityTypeConfiguration<Service>
{
    public void Configure(EntityTypeBuilder<Service> builder)
    {
        builder.HasKey(e => e.Id).HasName("PK__Services__3214EC070BF7A87F");

        builder.Property(e => e.Id).HasDefaultValueSql("(newid())");
        builder.Property(e => e.TotalCost).HasColumnType("decimal(18, 2)");

        builder.HasOne(d => d.ServiceType).WithMany(p => p.Services)
            .HasForeignKey(d => d.ServiceTypeId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_Servicios_TiposServicios");

        builder.HasOne(d => d.Vehicle).WithMany(p => p.Services)
            .HasForeignKey(d => d.VehicleId)
            .HasConstraintName("FK_Servicios_Vehiculos");
    }
}
