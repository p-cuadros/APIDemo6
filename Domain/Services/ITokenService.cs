namespace APIDemo.Domain.Services
{
    public interface ITokenService
    {
        string BuildToken(string key, string issuer,string audience, UserDto user);
    }
}