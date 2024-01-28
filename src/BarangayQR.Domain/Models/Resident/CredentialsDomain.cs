using BarangayQR.Domain.Models;
using BarangayQR.Domain.Models.ValueObject;

namespace BarangayQR.Domain.Models.Resident
{
    public class CredentialsDomain : BaseDomainModel
    {
        public Guid CredentialID { get; set; }
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
}
