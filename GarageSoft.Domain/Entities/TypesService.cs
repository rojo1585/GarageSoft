namespace GarageSoft.Domain.Entities;

public partial class TypesService
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string? Description { get; set; }
    public decimal SuggestedPrice { get; set; }
    public DateTime? RegistrationDate { get; set; }
    public virtual ICollection<Service> Services { get; set; } = new List<Service>();
}
