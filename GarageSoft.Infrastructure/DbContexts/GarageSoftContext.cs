using GarageSoft.Domain.Entities;
using GarageSoft.Infrastructure.DbContexts.Config;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace GarageSoft.Infrastructure.DbContexts;

public partial class GarageSoftContext : DbContext
{
    public GarageSoftContext()
    {
    }

    public GarageSoftContext(DbContextOptions<GarageSoftContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Client> Clients { get; set; }

    public virtual DbSet<Service> Services { get; set; }

    public virtual DbSet<TypesService> TypesServices { get; set; }

    public virtual DbSet<Vehicle> Vehicles { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new ClientConfig());
        modelBuilder.ApplyConfiguration(new ServicesConfig());
        modelBuilder.ApplyConfiguration(new TypeServiceConfig());
        modelBuilder.ApplyConfiguration(new VehicleConfig());
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
