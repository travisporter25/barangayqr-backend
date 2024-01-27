
using System.Data;

namespace BarangayQR.Core.Dapper
{
    public interface IDapperConnection
    {
        IDbConnection DatabaseReader { get; }
    }
}
