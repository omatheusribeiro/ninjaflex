using ninjaflex.Application.ViewModels;

namespace ninjaflex.Application.Interfaces
{
    public interface ILoginService
    {
        Task<ResponseViewModel> GetLogin(string? email, string? password, string? barCode);
    }
}
