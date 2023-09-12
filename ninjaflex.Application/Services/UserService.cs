using AutoMapper;
using ninjaflex.Application.Interfaces;
using ninjaflex.Application.ViewModels;
using ninjaflex.Data.Interfaces;
using ninjaflex.Domain.Entities;

namespace ninjaflex.Application.Services
{
    public class UserService : IUserService
    {
        private IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserService(IMapper mapper, IUserRepository userRepository)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<ResponseViewModel> GetUsers()
        {
            try
            {
                var users = await _userRepository.GetUsers();

                var retorno = _mapper.Map<IEnumerable<UserViewModel>>(users);

                return new ResponseViewModel { Message = "Requisição realizada com sucesso", Response = retorno, Success = true };

            }
            catch (Exception ex)
            {
                return new ResponseViewModel { Message = ex.Message, Error = "Houve um erro ao consultar os usuários!", Success = false };
            }

        }

        public async Task<ResponseViewModel> GetUserById(int id)
        {
            try
            {
                var user = await _userRepository.GetUserById(id);

                user.Password = "";

                var retorno = _mapper.Map<UserViewModel>(user);

                return new ResponseViewModel { Message = "Requisição realizada com sucesso", Response = retorno, Success = true };
            }
            catch (Exception ex)
            {
                return new ResponseViewModel { Message = ex.Message, Error = "Houve um erro ao consultar o usuário!", Success = false };
            }

        }

        public async Task<ResponseViewModel> PutUser(UserViewModel user)
        {
            try
            {
                var consultUser = await _userRepository.GetUserById(user.Id);

                user.DateAlteration = DateTime.Now;
                user.DateCreation = consultUser.DateCreation;

                var mapUser = _mapper.Map<User>(user);

                var result = await _userRepository.PutUser(mapUser);

                var retorno = _mapper.Map<UserViewModel>(result);

                return new ResponseViewModel { Message = "Requisição realizada com sucesso", Response = retorno, Success = true };
            }
            catch (Exception ex)
            {
                return new ResponseViewModel { Message = ex.Message, Error = "Houve um erro alterar o usuário!", Success = false };
            }

        }

        public async Task<ResponseViewModel> PostUser(UserViewModel user)
        {
            try
            {
                user.DateCreation = DateTime.Now;

                var mapUser = _mapper.Map<User>(user);

                var result = await _userRepository.PostUser(mapUser);

                var retorno = _mapper.Map<UserViewModel>(result);

                return new ResponseViewModel { Message = "Requisição realizada com sucesso", Response = retorno, Success = true };
            }
            catch (Exception ex)
            {
                return new ResponseViewModel { Message = ex.Message, Error = "Houve um erro inserir o usuário!", Success = false };
            }

        }
    }
}
