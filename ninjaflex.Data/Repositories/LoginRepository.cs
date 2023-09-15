using Microsoft.EntityFrameworkCore;
using ninjaflex.Data.Context;
using ninjaflex.Data.Interfaces;
using ninjaflex.Domain.Entities;

namespace ninjaflex.Data.Repositories
{
    public class LoginRepository : ILoginRepository
    {
        private ApplicationDbContext _context;

        public LoginRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<User> GetLogin(string? email, string? password, string? barCode)
        {
            if (string.IsNullOrEmpty(barCode) || !string.IsNullOrEmpty(email) || !string.IsNullOrEmpty(password))
            {
                return await _context.Users.AsNoTracking()
                                        .Where(u => u.Email.ToLower() == email.ToLower() &&
                                                    u.Password.ToLower() == password.ToLower()).FirstOrDefaultAsync();
            }
            else
            {
                return await _context.Users.AsNoTracking()
                                                        .Where(u => u.BarCode.ToLower() == barCode.ToLower()).FirstOrDefaultAsync();
            }
        }
    }
}
