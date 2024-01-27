namespace BarangayQR.Core.Entities;

public class CustomerBase : EntitiesBase
{
    public int? CustomerID { get; set; }
    public string? CustomerNumber { get; set; }
    public int? CustomerType { get; set; }
    public string? CustomerTypeName { get; set; }
    public string? FirstName { get; set; }
    public string? MiddleName { get; set; }
    public string? LastName { get; set; }
    public string? FullName { get; set; }
    public string? NickName { get; set; }
    public string? Title { get; set; }
    public string? Suffix { get; set; } 
    public string? Email { get; set; }
    public string? Mobile { get; set; }
    public string? Gender { get; set; }
    public string? CivilStatus { get; set; }
    public DateTime? BirthDate { get; set; }
    public string? ProfilePicture { get; set; } 

}
