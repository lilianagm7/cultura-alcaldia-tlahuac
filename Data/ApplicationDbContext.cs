
using CulturalesAlcaldia.Models;
using Microsoft.EntityFrameworkCore;
using CulturalesAlcaldia.Models;
namespace CulturalesAlcaldia.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Categoria> Categorias { get; set; }
    }
}
