using Microsoft.EntityFrameworkCore;

namespace CursoMvcTakeBlip.Models
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=BRUNO-PC;Database=CursoMVCTakeBlip;User Id=sa;Password=123456;");
        }

        public DbSet<Categoria> Categorias { get; set; }
    }
}
