using BarangayQR.Repository.Contract.Entities.ValueObject;

namespace BarangayQR.Repository.Contract.Entities.Resident;

public class CredentialEntity : EntityBase
{
    public Guid? CredentialID { get; set; }
    public string? CredentialNumber { get; set; }
    public string? CredentialName { get; set; }
    public string? Description { get; set; }
    public int? CredentialType { get; set; }
    public string? CredentialTypeName { get; set; }
    public string? FileName { get; set; }
    public string? Url { get; set; }
    public string? CredentialData { get; set; }

    public Image? Image { get; set; }

}
