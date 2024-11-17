using Microsoft.EntityFrameworkCore;
using Petzen.Models.Entities;

namespace Petzen.Contexto
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) :base(options){}
        public DbSet<Usuarios> usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.ApplyConfigurationsFromAssembly();
        }
    }
}
