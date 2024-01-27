namespace BarangayQR.Repository.Contract;

public class CustomerEntity
{
    public string? CustomerID { get; set; }
    public long? CustomerNumber { get; set; }
    public string? CustomerType { get; set; }
    public string? CustomerTypeName { get; set; }
    public string? FirstName { get; set; }
    public string? MiddleName { get; set; }
    public string? LastName { get; set; }
    public string? NickName { get; set; }
    public string? Email { get; set; }
    public string? Mobile { get; set; }
    public string? Occupation { get; set; }
    public string? Income { get; set; }
    public string? Gender { get; set; }
    public string? CivilStatus { get; set; }
    public DateTime? BirthDate { get; set; }
    public string? ProfileImage { get; set; }
    public bool IsActive { get; set; }
    public DateTime? CreatedDate { get; set; }
    public DateTime? ModifiedDate { get; set; }
    public string? CreatedBy { get; set; }
    public string? ModifiedBy { get; set; }

}
