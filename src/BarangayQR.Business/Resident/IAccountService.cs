using BarangayQR.Domain.Models.Resident;

namespace BarangayQR.Business.Resident
{
    public interface IAccountService
    {
        Task<AccountDomain> SaveDetails(AccountDomain data);
    }
}
