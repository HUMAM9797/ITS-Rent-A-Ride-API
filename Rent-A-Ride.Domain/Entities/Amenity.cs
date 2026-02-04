namespace Rent_A_Ride.Domain.Entities;
using Rent_A_Ride.Domain.Common;


/// <summary>
/// e.g., "GPS", "Child Seat". Many-to-Many with Rental via RentalAmenity.
/// </summary>
public class Amenity : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public decimal Price { get; set; }

    public ICollection<RentalAmenity> RentalAmenities { get; set; } = new List<RentalAmenity>();
}




