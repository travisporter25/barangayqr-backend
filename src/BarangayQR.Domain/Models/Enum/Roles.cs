
namespace BarangayQR.Domain.Models.Enum
{
    [Flags]
    public enum Roles
    {
        None = 1,
        [RoleDescription("Administration", "Admin")]
        Admin = 2,
        [RoleDescription("Residents", "Resident")]
        Resident = 3
    }
}
