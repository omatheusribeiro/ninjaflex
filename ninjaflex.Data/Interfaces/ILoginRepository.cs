using ninjaflex.Domain.Entities;

namespace ninjaflex.Data.Interfaces
{
    public interface ILoginRepository
    {
        Task<User> GetLogin(string? email, string? password, string? barCode);
    }
}
