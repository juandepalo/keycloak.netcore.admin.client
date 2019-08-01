using AutoMapper;


namespace Keycloak.ApiClient.Configurations
{
    public class AutoMapperConfig
    {
        public static MapperConfiguration RegisterMappings()
        {
            return new MapperConfiguration(cfg =>
            {
                cfg.AllowNullCollections = true;

            });
        }
    }
}