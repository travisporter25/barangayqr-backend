using BarangayQR.Core.Extensions;
using BarangayQR.Core;
using Microsoft.Extensions.Options;
using Dapper;
using BarangayQR.Core.Dapper;

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

        public async Task<List<T>> Get(object data)
        {
            using (var db = _connection.DatabaseReader.TryOpen())
            {
                var query =  @"";
                var result = await db.QueryAsync<T>(query, new { data });
                return result.ToList();
            }
        }
    }
}
