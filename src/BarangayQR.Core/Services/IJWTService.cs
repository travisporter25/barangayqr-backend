namespace BarangayQR.Core.Services;

public interface IJWTService<T> where T : class
{
    string GenerateToken(T DTO);
    Task<string> GenerateTokenAsync(T DTO);
}
