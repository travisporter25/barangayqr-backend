using BarangayQR.Core.Entities;

namespace BarangayQR.Core.Repository;

public interface ISearchRepository<T> where T : class
{
    Task<Search<T>> Get(DateTime DateFrom, DateTime DateTo, int CurrentPage, int PageSize);
    Task<Search<T>> GetAll(DateTime DateFrom, DateTime DateTo, int PageSize = 100);
    Task<Search<T>> Get(int CurrentPage, int PageSize, Dictionary<string, object>? param = null);
}
