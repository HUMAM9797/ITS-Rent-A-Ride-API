namespace Rent_A_Ride.Domain.Entities;

/// <summary>
/// Join entity for Many-to-Many between Rental and Amenity. A rental can have multiple amenities.
/// </summary>
public class RentalAmenity : BaseEntity
{
    public int RentalId { get; set; }
    public Rental Rental { get; set; } = null!;

    public int AmenityId { get; set; }
    public Amenity Amenity { get; set; } = null!;
}
