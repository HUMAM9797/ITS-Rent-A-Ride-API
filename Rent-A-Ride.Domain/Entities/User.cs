using Rent_A_Ride.Domain.Enums;

namespace Rent_A_Ride.Domain.Entities;

/// <summary>
/// Constraint: Email must be unique (Index - configure in Infrastructure).
/// </summary>
public class User : BaseEntity
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string PasswordHash { get; set; } = string.Empty;
    public UserRole Role { get; set; }

    // Navigation: One-to-Many with Rental
    public ICollection<Rental> Rentals { get; set; } = new List<Rental>();
}
