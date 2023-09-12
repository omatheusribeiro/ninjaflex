using AutoMapper;
using ninjaflex.Application.ViewModels;
using ninjaflex.Domain.Entities;

namespace ninjaflex.Application.Mappings
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<UserViewModel, User>();

            CreateMap<UserTypeViewModel, UserType>();
        }
    }
}
