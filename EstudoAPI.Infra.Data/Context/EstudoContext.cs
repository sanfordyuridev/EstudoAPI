using EstudoAPI.Domain.Entities;
using EstudoAPI.Infra.Configuration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
