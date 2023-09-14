using EstudoAPI.Infra.Configuration;
using Microsoft.EntityFrameworkCore;

namespace EstudoAPI.Infra.Context
{
   public class EstudoContext : DbContext
   {
        public EstudoContext(DbContextOptions<EstudoContext> opts) : base(opts) 
        { 

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new PessoaConfig());
        }
    }
}
