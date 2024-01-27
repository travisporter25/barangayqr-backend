
using BarangayQR.Domain.Models.Resident;

namespace BarangayQR.Business.Resident
{
    public interface IAddressService
    {
        Task<AddressDomain> SaveDetails(AccountDomain data);
    }
}
