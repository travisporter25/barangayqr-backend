namespace BarangayQR.Core.Entities;

public class EmployeeBase : EntitiesBase
{
    public int? EmployeeID { get; set; }
    public string? EmployeeNumber { get; set; }
    public int? EmployeeType { get; set; }
    public string? EmployeeTypeName { get; set; }
    public int UserID {  get; set; }
    public string? FirstName { get; set; }
    public string? MiddleName { get; set; }
    public string? LastName { get; set; }
    public string? FullName { get; set; }
    public string? NickName { get; set; }  
    public string? Email { get; set; }
    public string? Mobile { get; set; } 
    public string? Gender { get; set; }
    public string? CivilStatus { get; set; }
    public DateTime? BirthDate { get; set; }
    public string? ProfilePicture { get; set; } 


}
