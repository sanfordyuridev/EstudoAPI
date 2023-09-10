using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoAPI.Infra.Context
{
    public class DesignEstudoContext : IDesignTimeDbContextFactory<EstudoContext>
    {
        public EstudoContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<EstudoContext> builder = new DbContextOptionsBuilder<EstudoContext>();
            builder.UseMySQL("Host=localhost;Database=EstudoApi;Username=root;Password=root;");

            return new EstudoContext(builder.Options);
        }
    }
}
