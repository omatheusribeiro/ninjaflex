using ninjaflex.Domain.Entities;

namespace ninjaflex.Data.Interfaces
{
    public interface IUserTypeRepository
    {
        Task<IEnumerable<UserType>> GetUserTypes();
        Task<UserType> GetUserTypeById(int id);
        Task<UserType> PutUserType(UserType userType);
        Task<UserType> PostUserType(UserType userType);
    }
}
