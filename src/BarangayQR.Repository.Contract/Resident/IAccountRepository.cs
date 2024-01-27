
using BarangayQR.Repository.Contract.Entities.Resident;

namespace BarangayQR.Repository.Contract.Resident
{
    public interface IAccountRepository
    {
        Task<AccountEntity> SaveDetails(object parameter);
    }
}
