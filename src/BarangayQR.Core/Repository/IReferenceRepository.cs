using BarangayQR.Core.Entities;

namespace BarangayQR.Core.Repository;

public interface IReferenceRepository<T> where T : EntitiesBase
{
    Task<T> GetByReferenceID(long ReferenceID);
    Task<List<T>> GetListByReferenceID(long ReferenceID);
}
