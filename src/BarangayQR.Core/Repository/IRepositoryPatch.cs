using BarangayQR.Core.Entities;
namespace BarangayQR.Core.Repository;

public interface IRepositoryPatch<T> where T : EntitiesBase
{
    Task<T> Patch(T entity); 
}
