
using BarangayQR.Domain.Models.Resident;

namespace BarangayQR.Business.Resident
{
    public interface ICredentialService
    {
        Task<CredentialsDomain> SaveDetails(CredentialsDomain data);
    }
}
