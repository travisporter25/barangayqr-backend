using BarangayQR.BarangayQR.Core;
using Dapper;
using Microsoft.Extensions.Options;
using Microsoft.VisualBasic.FileIO;
using Npgsql;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace BarangayQR.Core.Dapper
{
    public class AppDatabaseConnection : IDapperConnection
    {
        private string _databaseConnectionString;
        private readonly AppSettings _settings;
        public AppDatabaseConnection(IOptions<AppSettings> settings)
        {
            _settings = settings.Value;
            _databaseConnectionString = _settings.ConnectionString;

        }
        public IDbConnection DatabaseReader
        {
            get
            {
                return new SqlConnection(_databaseConnectionString);
            }
        }
    }
}
