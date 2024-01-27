
using BarangayQR.Repository.Contract.Entities.Resident;

namespace BarangayQR.Repository.Contract.Resident
{
    public interface ICredentialRepository
    {
        Task<CredentialEntity> SaveDetails(object parameter);
    }
}
