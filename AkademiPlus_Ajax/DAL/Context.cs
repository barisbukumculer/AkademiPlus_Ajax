using Microsoft.EntityFrameworkCore;

namespace AkademiPlus_Ajax.DAL
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-5SF4DGP\\SQLEXPRESS;initial Catalog=AkademiPlusAjaxDb;integrated Security=true");
        }
        public DbSet<Product> Products { get; set; }
    }
}
