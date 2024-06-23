using Microsoft.EntityFrameworkCore;
using projetocarrofacu.Models;

namespace projetocarrofacu.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Nota> Notas { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Vendedor> Vendedores { get; set; }
        public DbSet<Carro> Carros { get; set; }
    }
}
