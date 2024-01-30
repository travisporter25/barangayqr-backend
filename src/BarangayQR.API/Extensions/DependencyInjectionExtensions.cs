using BarangayQR.API.Mappings;
using BarangayQR.Business.Resident;
using BarangayQR.Core.Dapper;
using BarangayQR.Repository.Contract.Resident;
using BarangayQR.Repository.Resident;
using BarangayQR.Services.Resident;

namespace BarangayQR.API.Extensions
{
    public static class DependencyInjectionExtensions
    {
        public static void ConfigureDependencies(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(DtoToDtoToDomainMapping));
            services.ConfigureRepositories();
            services.ConfigureServices();
        }
        public static void ConfigureRepositories(this IServiceCollection services)
        {
            services.AddTransient<IDapperConnection, AppDatabaseConnection>()
                    .AddTransient<IAccountRepository, AccountRepository>()
                    .AddTransient<IAddressRepository, AddressRepository>()
                    .AddTransient<ICredentialRepository, CredentialRepository>();
        }
        public static void ConfigureServices(this IServiceCollection services)
        {
            services.AddTransient<IAccountService, AccountService>()
                    .AddTransient<IAddressService, AddressService>()
                    .AddTransient<ICredentialService, CredentialService>();
        }
    }
}
