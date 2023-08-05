using HolaMundoAPI.API.Data.Models;

namespace HolaMundoAPI.API.Services
{
    public interface IUserService
    {
        Task<User>? GetUserAsync(string username, string password);
    }
}
