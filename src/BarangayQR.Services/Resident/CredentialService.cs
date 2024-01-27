using AutoMapper;
using BarangayQR.Business.Resident;
using BarangayQR.Domain.Models.Resident;
using BarangayQR.Repository.Contract.Resident;

namespace BarangayQR.Services.Resident
{
    public class CredentialService : ICredentialService
    {
        private readonly ICredentialRepository _credentialRepository;
        private readonly IMapper _mapper;
        public CredentialService(IMapper mapper, ICredentialRepository credentialRepository)
        {
            _mapper = mapper;
            _credentialRepository = credentialRepository;
        }
        public async Task<CredentialsDomain> SaveDetails(CredentialsDomain data)
        {
            var result = await _credentialRepository.SaveDetails(data);
            var mappedData = _mapper.Map<CredentialsDomain>(result);
            return mappedData;
        }
    }
}