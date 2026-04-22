namespace WebApi.Extensions.DependencyInjection
{
    public static class ApplicationDependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            var assembly = AppDomain.CurrentDomain.Load("Application");
            services.Scan(scan => scan.FromAssemblies(assembly)
                .AddClasses(x=>x.Where(t=>t.Name.EndsWith("Service")))
                //.AsImplementedInterfaces()
                .AsSelf()
                .WithScopedLifetime());
            return services;
        }
    }
}
