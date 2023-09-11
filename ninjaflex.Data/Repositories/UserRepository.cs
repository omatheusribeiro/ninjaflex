using Microsoft.EntityFrameworkCore;
using ninjaflex.Data.Context;
using ninjaflex.Data.Interfaces;
using ninjaflex.Domain.Entities;

namespace ninjaflex.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<User>> GetUsers()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<User> GetUserById(int id)
        {
            return await _context.Users.AsNoTracking().Where(u => u.Id == id).FirstOrDefaultAsync();
        }

        public async Task<User> PutUser(User user)
        {
            _context.Users.Update(user);
            await _context.SaveChangesAsync();

            return user;
        }

        public async Task<User> PostUser(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return user;
        }
    }
}
