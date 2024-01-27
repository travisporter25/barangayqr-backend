namespace BarangayQR.API.Option;

public class JWTSettingsOptions
{ 
    public string? Issuer { get; init; }
    public string? Audience { get; init; }
    public string? Key { get; init; }
}
