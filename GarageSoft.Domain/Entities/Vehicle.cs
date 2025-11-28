namespace GarageSoft.Domain.Entities;

public partial class Vehicle
{
    public Guid Id { get; set; }
    public string LicensePlate { get; set; } = null!;
    public string Brand { get; set; } = null!;
    public string Model { get; set; } = null!;
    public int Year { get; set; }
    public string Color { get; set; } = null!;
    public string? Vin { get; set; }
    public Guid ClientId { get; set; }
    public DateTime? FechaRegistro { get; set; }
    public virtual Client Client { get; set; } = null!;
    public virtual ICollection<Service> Services { get; set; } = new List<Service>();
}
