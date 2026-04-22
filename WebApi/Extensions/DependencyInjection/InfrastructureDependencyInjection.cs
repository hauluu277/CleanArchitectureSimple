namespace WebApi.Extensions.DependencyInjection
{
    public static class InfrastructureDependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            var assembly = AppDomain.CurrentDomain.Load("Infrastructure");
            services.Scan(scan => scan.FromAssemblies(assembly)
                .AddClasses(x => x.Where(t => t.Name.EndsWith("Repository")))
                .AsImplementedInterfaces()
                //.AsSelf()
                .WithScopedLifetime());
            return services;
        }   
    }
}
