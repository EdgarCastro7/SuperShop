using SuperShop.Data.Entities;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace SuperShop.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;

        private Random _random;

        public SeedDb(DataContext context)
        {
            _context = context;
            _random = new Random();
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync(); //Vai criar a Bd, se tiver criado segue a vida dele, se nao tiver, cria uma.

            if (!_context.Products.Any())
            {
                AddProduct("Iphone X");
                AddProduct("Magic Mouse");
                AddProduct("iWatch Series 4");
                AddProduct("Ipad Mini");
                await _context.SaveChangesAsync();
            }
        }

        private void AddProduct(string name)
        {
            _context.Products.Add(new Product
            {
                Name = name,
                Price = _random.Next(1000),
                IsAvailable = true,
                Stock = _random.Next(100)
            }); //Aqui adicionamos à BD o produto
        }
    }
}
