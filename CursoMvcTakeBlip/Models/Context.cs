using Microsoft.EntityFrameworkCore;

namespace CursoMvcTakeBlip.Models
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=tcp:cursomvctakeblipdbserver.database.windows.net,1433;Initial Catalog=CursoMvcTakeBlip_db;Persist Security Info=False;User ID=adm_bruno;Password=Brun0H3rick;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }
    }
}
