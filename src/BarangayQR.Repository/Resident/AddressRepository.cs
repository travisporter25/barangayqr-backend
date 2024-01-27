
using BarangayQR.BarangayQR.Core.Extensions;
using BarangayQR.Core.Dapper;
using BarangayQR.Repository.Contract;

namespace BarangayQR.Repository.Resident
{
    public class AddressRepository
    {
        private readonly IDapperConnection _connection;
        public AddressRepository(IDapperConnection connection)
        {
            _connection = connection;
        }
        
        public async Task<AddressEntity> SaveDetails(object parameter)
        {
            using (var db = _connection.DatabaseReader.TryOpen())
            {
                var query = @"INSERT INTO (@)";
            }
        }
    }
}
