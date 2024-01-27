﻿
using BarangayQR.Core;
using Microsoft.Extensions.Options;
using Dapper;
using BarangayQR.Core.Dapper;
using BarangayQR.BarangayQR.Core.Extensions;
using System.Reflection.Metadata;
using BarangayQR.BarangayQR.Core;

namespace BarangayQR.Repository
{
    public class AdminRepository<T> where T : class
    {
        private readonly AppSettings _settings;
        private readonly IDapperConnection _connection;
        public AdminRepository(IOptions<AppSettings> settings)
        {
            _settings = settings.Value;
        }

        public async Task<List<T>> Get(object parameter)
        {
            using (var db = _connection.DatabaseReader.TryOpen())
            {
                string query = string.Empty;
                var accountExist = db.Query<T>(@"SELECT * FROM dbo.Account WHERE ClientId = @ClientId AND BranchId = @BranchId", parameter).Any() ? true : false;
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
                            
                              SELECT * FROM dbo.Account WHERE ClientId = @ClientId AND BranchId = @BranchId"
                    ;
                }

                var result = await db.QueryAsync<T>(query, parameter);
                return result.ToList();
            }
        }
    }
}
