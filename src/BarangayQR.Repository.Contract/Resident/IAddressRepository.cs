using BarangayQR.Repository.Contract.Entities.Resident;

namespace BarangayQR.Repository.Contract.Resident
{
    public interface IAddressRepository
    {
        Task<AddressEntity> SaveDetails(object parameter);
    }
}
