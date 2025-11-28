namespace GarageSoft.Shared.DTOs.Services;

public class ServiceDto
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid VehicleId { get; set; }
    public string Description { get; set; } = string.Empty; // Mapeado a Notes o Description
    public DateTime Date { get; set; } = DateTime.Now;
    public decimal Cost { get; set; }
}
