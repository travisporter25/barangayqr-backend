using AutoMapper;
using BarangayQR.API.Model;
using BarangayQR.Domain.Models.Resident;

namespace BarangayQR.API.Mappings
{
    public class DtoToDtoToDomainMapping : Profile
    {
        public DtoToDtoToDomainMapping()
        {
            CreateMap<AccountDto, AccountDomain>().ReverseMap();
        }
    }
}
