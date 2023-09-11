using Microsoft.EntityFrameworkCore;
using ninjaflex.Data.Context;
using ninjaflex.Data.Interfaces;
using ninjaflex.Domain.Entities;

namespace ninjaflex.Data.Repositories
{
    public class UserTypeRepository : IUserTypeRepository
    {
        private ApplicationDbContext _context;

        public UserTypeRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<UserType>> GetUserTypes()
        {
            return await _context.UserTypes.ToListAsync();
        }

        public async Task<UserType> GetUserTypeById(int id)
        {
            return await _context.UserTypes.AsNoTracking().Where(u => u.Id == id).FirstOrDefaultAsync();
        }

        public async Task<UserType> PutUserType(UserType userType)
        {
            _context.UserTypes.Update(userType);
            await _context.SaveChangesAsync();

            return userType;
        }

        public async Task<UserType> PostUserType(UserType userType)
        {
            _context.UserTypes.Add(userType);
            await _context.SaveChangesAsync();

            return userType;
        }
    }
}
