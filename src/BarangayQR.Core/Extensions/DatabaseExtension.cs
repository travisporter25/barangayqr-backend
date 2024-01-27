
using Microsoft.Extensions.Options;
using System.Data;
using System.Data.SqlClient;

namespace BarangayQR.BarangayQR.Core.Extensions
{
    public static class DatabaseExtension
    {
        public static IDbConnection TryOpen(this IDbConnection connection)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();

            return connection;
        }

    }
}
