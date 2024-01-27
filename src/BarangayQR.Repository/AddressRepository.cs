
using BarangayQR.Core.Dapper;

namespace BarangayQR.Repository
{
    public class AddressRepository
    {
        private readonly IDapperConnection _connection;
        public AddressRepository(IDapperConnection connection)
        {
            _connection = connection;
        }
    }
}
