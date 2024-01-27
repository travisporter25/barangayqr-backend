using BarangayQR.Core.Entities;

namespace BarangayQR.Core.Repository;

public interface ICustomQueryRepository<T> where T : EntitiesBase
{
    Task<T> GetByQuery(string sql, object? param = null);
    Task<List<T>> GetListByQuery(string sql, object? param = null);
}
