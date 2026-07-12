using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SuperShop.Data.Entities;

namespace SuperShop.Data
{
    public class DataContext : IdentityDbContext<User>
    {
        public DbSet<Product> Products { get; set; } //Products e a propriedade que vai ficar ligada a tabela Product
                                                     //quando ela for criada, atraés do DataContext

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
    }
}
