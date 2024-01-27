using BarangayQR.Core.Entities;

namespace BarangayQR.Core.Repository;

public interface IRelationRepository<T> where T : RelationEntitiesBase
{
    Task<List<T>> GetByPrimaryKey(T entity);
    Task<List<T>> GetByForeignKey(T entity); 
    Task<T> Get(long RelationID);
    Task<long> Insert(T entity);
    Task Update(T entity);
    Task<long> Upsert(T entity);
    Task Delete(long RelationID);
}
