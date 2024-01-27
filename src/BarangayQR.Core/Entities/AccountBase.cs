namespace BarangayQR.Core.Entities;

public class AccountBase : EntitiesBase
{
    public int? AccountID { get; set; }
    public string? AccountNumber { get; set; }
    public int? AccountType { get; set; }
    public string? AccountTypeName { get; set; }
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
