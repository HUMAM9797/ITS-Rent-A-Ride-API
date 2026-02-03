using Rent_A_Ride.Domain.Enums;

namespace Rent_A_Ride.Domain.Entities;

/// <summary>
/// One-to-Many with Rental. Many-to-One with VehicleType.
/// </summary>
public class Vehicle : BaseEntity
{
    public string Model { get; set; } = string.Empty;
    public int Year { get; set; }
    public string LicensePlate { get; set; } = string.Empty;
    public decimal DailyPrice { get; set; }
    public VehicleStatus Status { get; set; }

    public int VehicleTypeId { get; set; }
    public VehicleType VehicleType { get; set; } = null!;

    // One-to-One with VehicleMaintenance (vehicle has exactly one maintenance record)
    public VehicleMaintenance? Maintenance { get; set; }

    public ICollection<Rental> Rentals { get; set; } = new List<Rental>();
}
