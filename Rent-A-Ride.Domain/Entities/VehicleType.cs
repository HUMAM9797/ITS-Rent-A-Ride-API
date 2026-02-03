namespace Rent_A_Ride.Domain.Entities;

/// <summary>
/// e.g., "SUV", "Economy", "Salon". Relationship: One-to-Many with Vehicle.
/// </summary>
public class VehicleType : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;

    public ICollection<Vehicle> Vehicles { get; set; } = new List<Vehicle>();
}
