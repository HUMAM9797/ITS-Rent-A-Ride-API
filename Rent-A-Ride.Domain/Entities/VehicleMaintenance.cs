using Rent_A_Ride.Domain.Common;
namespace Rent_A_Ride.Domain.Entities;

/// <summary>
/// One-to-One with Vehicle. A vehicle has exactly one maintenance record.
/// </summary>
public class VehicleMaintenance : BaseEntity
{
    public string Description { get; set; } = string.Empty;
    public DateTime? LastMaintenanceDate { get; set; }
    public DateTime? NextMaintenanceDue { get; set; }

    public int VehicleId { get; set; }
    public Vehicle Vehicle { get; set; } = null!;
}





