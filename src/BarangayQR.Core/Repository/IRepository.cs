using BarangayQR.Core.Entities;
using System.Threading.Tasks;

namespace BarangayQR.Core.Repository;

public interface IRepository<T> where T : EntitiesBase
{ 
    Task<T> GetById(long ID);
    Task<T> GetByStringId(string ID);
    Task<long> Insert(T entity);
    Task Update(T entity);
    Task<long> Upsert(T entity);
    Task DeleteByStringID(string ID);
    Task Delete(long ID);
}
