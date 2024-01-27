using AutoMapper;
using BarangayQR.Business.Resident;
using BarangayQR.Domain.Models.Resident;
using BarangayQR.Repository.Contract.Resident;

namespace BarangayQR.Services.Resident
{
    public class AddressService : IAddressService
    {
        private readonly IAddressRepository _addressRepository;
        private readonly IMapper _mapper;
        public AddressService(IAddressRepository addressRepository, IMapper mapper)
        {
            _mapper = mapper;
            _addressRepository = addressRepository;
        }
        public async Task<AddressDomain> SaveDetails(AccountDomain data)
        {
            var result = await _addressRepository.SaveDetails(data);
            var mappedData = _mapper.Map<AddressDomain>(result);
            return mappedData;
        }
    }
}
