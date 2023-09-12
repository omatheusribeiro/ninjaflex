using AutoMapper;
using ninjaflex.Application.Interfaces;
using ninjaflex.Application.ViewModels;
using ninjaflex.Data.Interfaces;
using ninjaflex.Domain.Entities;

namespace ninjaflex.Application.Services
{
    public class UserTypeService : IUserTypeService
    {
        private IUserTypeRepository _userTypeRepository;
        private readonly IMapper _mapper;

        public UserTypeService(IMapper mapper, IUserTypeRepository userTypeRepository)
        {
            _userTypeRepository = userTypeRepository;
            _mapper = mapper;
        }

        public async Task<ResponseViewModel> GetUserTypes()
        {
            try
            {
                var userTypes = await _userTypeRepository.GetUserTypes();

                var retorno = _mapper.Map<IEnumerable<UserTypeViewModel>>(userTypes);

                return new ResponseViewModel { Message = "Requisição realizada com sucesso", Response = retorno, Success = true };

            }
            catch (Exception ex)
            {
                return new ResponseViewModel { Message = ex.Message, Error = "Houve um erro ao consultar os tipos de usuário!", Success = false };
            }

        }

        public async Task<ResponseViewModel> GetUserTypeById(int id)
        {
            try
            {
                var userType = await _userTypeRepository.GetUserTypeById(id);

                var retorno = _mapper.Map<UserTypeViewModel>(userType);

                return new ResponseViewModel { Message = "Requisição realizada com sucesso", Response = retorno, Success = true };
            }
            catch (Exception ex)
            {
                return new ResponseViewModel { Message = ex.Message, Error = "Houve um erro ao consultar o tipo de usuário!", Success = false };
            }

        }

        public async Task<ResponseViewModel> PutUserType(UserTypeViewModel userType)
        {
            try
            {
                var consultUserType = await _userTypeRepository.GetUserTypeById(userType.Id);

                userType.DateAlteration = DateTime.Now;
                userType.DateCreation = consultUserType.DateCreation;

                var mapUserType = _mapper.Map<UserType>(userType);

                var result = await _userTypeRepository.PutUserType(mapUserType);

                var retorno = _mapper.Map<UserTypeViewModel>(result);

                return new ResponseViewModel { Message = "Requisição realizada com sucesso", Response = retorno, Success = true };
            }
            catch (Exception ex)
            {
                return new ResponseViewModel { Message = ex.Message, Error = "Houve um erro alterar o tipo de usuário!", Success = false };
            }

        }

        public async Task<ResponseViewModel> PostUserType(UserTypeViewModel usertype)
        {
            try
            {
                usertype.DateCreation = DateTime.Now;

                var mapUserType = _mapper.Map<UserType>(usertype);

                var result = await _userTypeRepository.PostUserType(mapUserType);

                var retorno = _mapper.Map<UserTypeViewModel>(result);

                return new ResponseViewModel { Message = "Requisição realizada com sucesso", Response = retorno, Success = true };
            }
            catch (Exception ex)
            {
                return new ResponseViewModel { Message = ex.Message, Error = "Houve um erro inserir o tipo de usuário!", Success = false };
            }

        }
    }
}
