using SuperShop.Data.Entities;

namespace SuperShop.Data
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        //Como é generico nao se tem de fazer nada. Fazemos isto para depois no startup nas depencies temos de o chama-lo
    }
}
