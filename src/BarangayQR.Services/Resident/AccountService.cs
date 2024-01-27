
using AutoMapper;
using BarangayQR.Business.Resident;
using BarangayQR.Domain.Models.Resident;
using BarangayQR.Repository.Contract.Resident;

namespace BarangayQR.Services.Resident
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;
        private readonly IMapper _mapper;
        public AccountService(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }
        public async Task<AccountDomain> SaveDetails(AccountDomain data)
        {
            var result = await _accountRepository.SaveDetails(data);
            var mappedData = _mapper.Map<AccountDomain>(result);
            return mappedData;
        }
    }
}
