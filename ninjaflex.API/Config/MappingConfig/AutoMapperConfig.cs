using ninjaflex.Application.Mappings;

namespace ninjaflex.API.Config.MappingConfig
{
    public static class AutoMapperConfig
    {
        public static void AddAutoMapperConfiguration(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            services.AddAutoMapper(typeof(DomainToViewModelMappingProfile),
                    typeof(ViewModelToDomainMappingProfile));
        }
    }
}
