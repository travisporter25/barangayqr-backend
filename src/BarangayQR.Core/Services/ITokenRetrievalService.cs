using BarangayQR.Core.Entities;

namespace BarangayQR.Core.Services;
public interface ITokenRetrievalService<T> where T : TokenBase
{
    T Get();
    Task<T> GetTokenAsync();
    Task<T> GetToken(string UserName , string Password);
}
