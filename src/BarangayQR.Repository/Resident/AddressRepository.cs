
using BarangayQR.BarangayQR.Core.Extensions;
using BarangayQR.Core.Dapper;
using BarangayQR.Repository.Contract.Entities.Resident;
using BarangayQR.Repository.Contract.Resident;
using Dapper;

namespace BarangayQR.Repository.Resident
{
    public class AddressRepository : IAddressRepository
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
                string query = string.Empty;
                var accountExist = db.Query<AddressEntity>(@"SELECT * FROM dbo.Account WHERE ClientId = @ClientId AND BranchId = @BranchId", parameter).Any() ? true : false;
                if (!accountExist)
                {
                    query = @"INSERT INTO ( ClientId, BranchId, AddressID, AddressType, Barangay, Street, City, Region, Province, ZipCode,
                                          ContactName, ContactNumber ) VALUES
                                          ( @ClientId, @BranchId, @AddressID, @AddressType, @Barangay, @Street, @City, @Region, @Province, @ZipCode,
                                            @ContactName, @ContactNumber )
                              SELECT * FROM dbo.Account WHERE ClientId = @ClientId AND BranchId = @BranchId";
                }
                else
                {
                    query = @"UPDATE dbo.Account 
                              SET 
                              AddressID = @AddressID,
                              AddressType = BarangayAddressType,
                              Barangay = @Street,
                              Street = @Street,
                              City = @City,
                              Region = @Region,
                              Province = @Province,
                              ZipCode = @ZipCode,
                              ContactName = @ContactName,
                              ContactNumber = @ContactNumber
                              WHERE ClientId = @ClientId AND BranchId = @BranchId
                            
                              SELECT * FROM dbo.Account WHERE ClientId = @ClientId AND BranchId = @BranchId";
                }

                var result = await db.QueryFirstOrDefaultAsync<AddressEntity>(query, parameter);
                return result;
            }
        }
    }
}
