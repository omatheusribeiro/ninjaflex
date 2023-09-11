using ninjaflex.Domain.Entities;

namespace ninjaflex.Data.Interfaces
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetUsers();
        Task<User> GetUserById(int id);
        Task<User> PutUser(User user);
        Task<User> PostUser(User user);
    }
}
