using AutoMapper;
using BarangayQR.API.Model;
using BarangayQR.BarangayQR.Core;
using BarangayQR.Business.Resident;
using BarangayQR.Core;
using BarangayQR.Domain.Models.Resident;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace BarangayQR.API.Controllers
{
    [Authorize]
    [Route("register-service/api/[controller]")]
    [ApiController]
    public class RegisterController : ClientControllerBase
    {
        private readonly IAccountService _accountService;
        private readonly IMapper _mapper;
        private readonly AppSettings _settings;
        public RegisterController
        (
            IAccountService account,
            IMapper mapper,
            IOptions<AppSettings> settings
        )
        {
            _accountService = _accountService;
            _mapper = mapper;
            _settings = settings.Value;
        }

        [HttpPost("account")]
        public async Task<IActionResult> SaveAccountDetails(AccountDto data)
        {
            var mappedData = _mapper.Map<AccountDomain>(data);
            var response = _accountService.SaveDetails(mappedData);
            return Ok(new
            {
                Data = response,
                Success = true
            });
        }
    }
}
