
using BarangayQR.Core.ValueObject;

namespace BarangayQR.Core.Services;

public interface IBlobStorageService
{
    Task<Image> GetByFileName(string fileName); 
    Task<Image> Upload(Image image);
}
