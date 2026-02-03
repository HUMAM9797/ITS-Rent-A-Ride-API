using Rent_A_Ride.Domain.Enums;

namespace Rent_A_Ride.Domain.Entities;

/// <summary>
/// Many-to-One with User and Vehicle. Many-to-Many with Amenity via RentalAmenity.
/// </summary>
public class Rental : BaseEntity
{
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public decimal TotalPrice { get; set; }
    public RentalStatus Status { get; set; }

    public int UserId { get; set; }
    public User User { get; set; } = null!;

    public int VehicleId { get; set; }
    public Vehicle Vehicle { get; set; } = null!;

    public ICollection<RentalAmenity> RentalAmenities { get; set; } = new List<RentalAmenity>();
}
