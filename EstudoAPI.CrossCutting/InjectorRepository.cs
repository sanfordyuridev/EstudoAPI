using EstudoAPI.Domain.Interfaces.Data;
using EstudoAPI.Infra.Data;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
