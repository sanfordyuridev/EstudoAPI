﻿using EstudoAPI.Domain.Interfaces.Services;
using Microsoft.Extensions.DependencyInjection;

namespace EstudoAPI.CrossCutting
{
    public static class InjectorService
    {
        public static void RegisterService(this IServiceCollection services)
        {
            services.AddScoped<IPessoaService, IPessoaService>();
        }
    }
}
