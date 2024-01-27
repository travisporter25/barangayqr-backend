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
                    query = @"INSERT INTO ( CredentialID, CredentialNumber, CredentialName, Description, CredentialType, CredentialTypeName, FileName, Url, CredentialData ) VALUES
                                          ( @CredentialID, @CredentialNumber, @CredentialName, @Description, @CredentialType, @CredentialTypeName, @FileName, @Url, @CredentialData )
                              SELECT * FROM dbo.Account WHERE ClientId = @ClientId AND BranchId = @BranchId";
                }
                else
                {
                    query = @"UPDATE dbo.Account 
                              SET 
                              CredentialID = @CredentialID,
                              CredentialNumber = @CredentialNumber,
                              CredentialName = @CredentialName,
                              Description = @Description,
                              CredentialType = @CredentialType,
                              CredentialTypeName = @CredentialTypeName,
                              FileName = @FileName,
                              Url = @Url,
                              CredentialData = @CredentialData
                              WHERE ClientId = @ClientId AND BranchId = @BranchId
                            
                              SELECT * FROM dbo.Account WHERE ClientId = @ClientId AND BranchId = @BranchId";
                }

                var result = await db.QueryFirstOrDefaultAsync<CredentialEntity>(query, parameter);
                return result;
            }
        }
    }
}
