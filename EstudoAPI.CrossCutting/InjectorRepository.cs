using EstudoAPI.Domain.Interfaces.Data;
using EstudoAPI.Infra.Data;
using Microsoft.Extensions.DependencyInjection;

namespace EstudoAPI.CrossCutting
{
    public static class InjectorRepository
    {
        public static void RegisterRepository(this IServiceCollection services)
        {
            services.AddScoped<IPessoaRepository, PessoaRepository>();
        }
    }
}
