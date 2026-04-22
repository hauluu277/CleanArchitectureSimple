namespace WebApi.Extensions.DependencyInjection
{
    public static class AutoMapperDependencyInjection
    {
        public static IServiceCollection AddAutoMapperProfiles(this IServiceCollection services)
        {
            //var assembly = AppDomain.CurrentDomain.Load("WebApi");
            var assemblies = new[] {
            // typeof(Application.AssemblyMarker).Assembly,
            //typeof(WebApi.Program).Assembly
             AppDomain.CurrentDomain.Load("Application"), // Thêm assembly Application
             AppDomain.CurrentDomain.Load("Infrastructure"), // Thêm assembly Infrastructure
             AppDomain.CurrentDomain.Load("WebApi")
            };

            services.AddAutoMapper(assemblies);
            return services;


        }
    }
}
