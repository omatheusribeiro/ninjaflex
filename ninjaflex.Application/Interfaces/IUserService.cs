using ninjaflex.Application.ViewModels;

namespace ninjaflex.Application.Interfaces
{
    public interface IUserService
    {
        Task<ResponseViewModel> GetUsers();
        Task<ResponseViewModel> GetUserById(int id);
        Task<ResponseViewModel> PutUser(UserViewModel user);
        Task<ResponseViewModel> PostUser(UserViewModel user);
    }
}
