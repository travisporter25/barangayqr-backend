namespace BarangayQR.Core.Entities;

public class UserBase : EntitiesBase
{
    public int? UserID { get; set; }
    public int? UserType { get; set; }
    public string? UserTypeName { get; set; }
    public string? UserName { get; set; }
    public string? Password { get; set; }  

}
