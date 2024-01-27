
using BarangayQR.BarangayQR.Core.Extensions;
using BarangayQR.Core.Dapper;
using BarangayQR.Repository.Contract.Entities.Resident;
using BarangayQR.Repository.Contract.Resident;
using Dapper;

namespace BarangayQR.Repository.Resident
{
    public class AccountRepository : IAccountRepository
    {
        private readonly IDapperConnection _connection;
        public AccountRepository(IDapperConnection connection)
        {
            _connection = connection;
        }

        public async Task<AccountEntity> SaveDetails(object parameter)
        {
            using (var db = _connection.DatabaseReader.TryOpen())
            {
                string query = string.Empty;
                var accountExist = db.Query<AccountEntity>(@"SELECT * FROM dbo.Account WHERE ClientId = @ClientId AND BranchId = @BranchId", parameter).Any() ? true : false;
                if (!accountExist)
                {
                    query = @"INSERT INTO ( ClientId, BranchId, AccountId, FirstName, MiddleName, LastName, Suffix, NickName, Email,
                                          Mobile, Gender, CivilStatus, BirthDate ) VALUES
                                          ( @ClientId, @BranchId, @AccountId, @FirstName, @MiddleName, @LastName, @Suffix, @NickName, @Email,
                                            @Mobile, @Gender, @CivilStatus, @BirthDate )
                              SELECT * FROM dbo.Account WHERE ClientId = @ClientId AND BranchId = @BranchId";
                }
                else
                {
                    query = @"UPDATE dbo.Account 
                              SET 
                              AccountId = @AccountId,
                              FirstName = @FirstName,
                              MiddleName = @MiddleName,
                              LastName = @LastName,
                              Suffix = @Suffix,
                              NickName = @NickName,
                              Email = @Email,
                              Mobile = @Mobile,
                              Gender = @Gender,
                              CivilStatus = @CivilStatus,
                              BirthDate = @BirthDate
                              WHERE ClientId = @ClientId AND BranchId = @BranchId
                            
                              SELECT * FROM dbo.Account WHERE ClientId = @ClientId AND BranchId = @BranchId";
                }

                var result = await db.QueryFirstOrDefaultAsync<AccountEntity>(query, parameter);
                return result;
            }
        }
    }
}
