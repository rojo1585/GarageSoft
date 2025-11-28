namespace GarageSoft.Domain.Entities;

public partial class Service
{
    public Guid Id { get; set; }

    public int Mileage { get; set; }

    public string? Notes { get; set; }

    public decimal TotalCost { get; set; }

    public DateTime ServiceDate { get; set; }

    public Guid VehicleId { get; set; }

    public int ServiceTypeId { get; set; }

    public virtual TypesService ServiceType { get; set; } = null!;

    public virtual Vehicle Vehicle { get; set; } = null!;
}
