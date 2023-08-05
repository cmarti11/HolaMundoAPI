using HolaMundoAPI.API.Data.Models;

namespace HolaMundoAPI.API.Services
{
    public interface IAccountService
    {
        string GenerateJwtToken(User user);
    }
}
