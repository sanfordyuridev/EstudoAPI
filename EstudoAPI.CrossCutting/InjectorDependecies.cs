using EstudoAPI.Infra.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace EstudoAPI.CrossCutting
{
    public static class InjectorDependecies
    {
        public static void RegisterDependencies(this IServiceCollection services, string defaultConnection)
        {
            services.AddDbContext<EstudoContext>(opts =>
            {
                opts.UseMySQL(defaultConnection);
                opts.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            });
            services.RegisterRepository();
            services.RegisterService();
        }
    }
}
