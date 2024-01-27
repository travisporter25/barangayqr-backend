using BarangayQR.Core.Entities;
using BarangayQR.Core.ValueObject;

namespace BarangayQR.Core.Repository;

public interface IChoiceRepository<T> where T : EntitiesBase
{
    Task<List<T>> GetDefaultList();
    Task<List<Choice>> GetDefaultChoiceList();
    List<Choice> ToChoiceList(List<T> ListEntities);
}
