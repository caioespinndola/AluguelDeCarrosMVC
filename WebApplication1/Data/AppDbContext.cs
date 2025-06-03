
using AluguelDeCarrosMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace AluguelDeCarros.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Carro> Carros { get; set; }
        public DbSet<WebApplication1.Models.Usuario> Usuarios { get; set; }
        public DbSet<Aluguel> Alugueis { get; set; }
        public DbSet<WebApplication1.Models.SuporteMensagem> WebApplication { get; set; }
    }
}
