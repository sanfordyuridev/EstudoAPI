using EstudoAPI.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace EstudoAPI.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> opts) : base(opts) { 



        }   

        public DbSet<Pessoa> Pessoas { get; set; }

    }
}
