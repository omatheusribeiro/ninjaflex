
using AutoMapper;
using ninjaflex.Application.ViewModels;
using ninjaflex.Domain.Entities;

namespace ninjaflex.Application.Mappings
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<User, UserViewModel>();

            CreateMap<UserType, UserTypeViewModel>();
        }
    }
}
