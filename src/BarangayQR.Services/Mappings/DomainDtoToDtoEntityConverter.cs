
using AutoMapper;
using BarangayQR.Domain.Models.Resident;
using BarangayQR.Repository.Contract.Entities.Resident;

namespace BarangayQR.Services.Mappings
{
    public class DomainDtoToDtoEntityConverter : Profile
    {
        public DomainDtoToDtoEntityConverter()
        {
            CreateMap<AccountDomain, AccountEntity>().ReverseMap();
        }
    }
}
