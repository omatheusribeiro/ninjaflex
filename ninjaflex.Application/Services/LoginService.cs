using AutoMapper;
using ninjaflex.Application.Helpers;
using ninjaflex.Application.Interfaces;
using ninjaflex.Application.ViewModels;
using ninjaflex.Data.Interfaces;

namespace ninjaflex.Application.Services
{
    public class LoginService : ILoginService
    {
        private ILoginRepository _loginRepository;
        private readonly IMapper _mapper;

        public LoginService(IMapper mapper, ILoginRepository loginRepository)
        {
            _loginRepository = loginRepository;
            _mapper = mapper;
        }

        public async Task<ResponseViewModel> GetLogin(string? email, string? password, string? barCode)
        {
            try
            {
                dynamic result;

                if (!string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(password) || !string.IsNullOrEmpty(barCode))
                {
                     result = await _loginRepository.GetLogin(email, password, barCode);
                }
                else
                {
                    return new ResponseViewModel { Message = "", Error = "Usuário ou código de barras não informado!", Success = false };
                }
                

                if (result != null)
                {
                    var token = TokenConfig.GenerateToken(result);

                    return new ResponseViewModel { Message = "Requisição realizada com sucesso", Response = token, Success = true };
                }
                else
                {
                    return new ResponseViewModel { Message = "", Error = "Não foi possível encontrar o usuário!", Success = false };
                }
                
            }
            catch(Exception ex)
            {
                return new ResponseViewModel { Message = ex.Message, Error = "Houve um erro ao autenticar o usuário!", Success = false };
            }
            
        }
    }
}
