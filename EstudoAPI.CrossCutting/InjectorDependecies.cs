using EstudoAPI.Infra.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoAPI.CrossCutting
{
    public static class InjectorDependecies
    {
        public static void RegisterDependencies(this IServiceCollection services, string defaultConnection)
        {
            services.AddDbContext<EstudoContext>(opts => opts.UseMySQL(defaultConnection));
            services.RegisterRepository();
            services.RegisterService();
        }
    }
}
