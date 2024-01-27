using BarangayQR.BarangayQR.Core.Extensions;
using BarangayQR.Core.Dapper;
using BarangayQR.Repository.Contract.Entities.Resident;
using BarangayQR.Repository.Contract.Resident;
using Dapper;

namespace BarangayQR.Repository.Resident
{
    public class CredentialRepository : ICredentialRepository
    {
        private readonly IDapperConnection _connection;
        public CredentialRepository(IDapperConnection connection)
        {
            _connection = connection;
        }
        public async Task<CredentialEntity> SaveDetails(object parameter)
        {
            using (var db = _connection.DatabaseReader.TryOpen())
            {
                string query = string.Empty;
                var accountExist = db.Query<CredentialEntity>(@"SELECT * FROM dbo.Account WHERE ClientId = @ClientId AND BranchId = @BranchId", parameter).Any() ? true : false;
                if (!accountExist)
                {
                    query = @"INSERT INTO ( ClientId, BranchId, AddressType, Barangay, Street, City, Region, Province, ZipCode,
                                          ContactName, ContactNumber ) VALUES
                                          ( @ClientId, @BranchId, @AddressType, @Barangay, @Street, @City, @Region, @Province, @ZipCode,
                                            @ContactName, @ContactNumber )
                              SELECT * FROM dbo.Account WHERE ClientId = @ClientId AND BranchId = @BranchId";
                }
                else
                {
                    query = @"UPDATE dbo.Account 
                              SET 
                              AddressType = @AddressType,
                              AddressType = @AddressType,
                              AddressType = @AddressType,
                              AddressType = @AddressType,
                              AddressType = @AddressType,
                              AddressType = @AddressType,
                              AddressType = @AddressType,
                              AddressType = @AddressType,
                              AddressType = @AddressType
                              WHERE ClientId = @ClientId AND BranchId = @BranchId
                            
                              SELECT * FROM dbo.Account WHERE ClientId = @ClientId AND BranchId = @BranchId";
                }

                var result = await db.QueryFirstOrDefaultAsync<CredentialEntity>(query, parameter);
                return result;
            }
        }
    }
}
