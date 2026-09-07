using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using SuperShop.Data.Entities;
using System.Linq;

namespace SuperShop.Data
{
    public class DataContext : IdentityDbContext<User>
    {
        public DbSet<Product> Products { get; set; } //Products e a propriedade que vai ficar ligada a tabela Product
                                                     //quando ela for criada, através do DataContext

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderDetail> OrderDetails { get; set; }

        public DbSet<OrderDetailTemp> OrderDetailTemps { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        //Habilitar a regra de apagar em cascata (Cascade Delete Rule)
        //protected override void OnModelCreating(ModelBuilder modelBuilder) //apagar em cascata
        //{
        //    var cascadeFKs = modelBuilder.Model
        //        .GetEntityTypes() //Vai buscar todas as tabelas
        //        .SelectMany(t => t.GetForeignKeys()) //Seleciona todas as FKs
        //        .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade); //Aqui procuramos todas as FKs que tenham o comportamento cascata
            
        //    foreach (var fk in cascadeFKs)
        //    {
        //        fk.DeleteBehavior = DeleteBehavior.Cascade;
        //    }

        //    base.OnModelCreating(modelBuilder);
        //}
    }
}
