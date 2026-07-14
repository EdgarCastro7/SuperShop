using SuperShop.Data.Entities;
using SuperShop.Models;

namespace SuperShop.Helpers
{
    public class ConverterHelper : IConverterHelper
    {
        public Product ToProduct(ProductViewModel model,string path, bool isNew)
        {
            return new ProductViewModel
            {
                Id = isNew ? 0 : model.Id,
                Name = model.Name,
                LastPurchase = model.LastPurchase,
                LastSale = model.LastSale,
                Price = model.Price,
                ImageUrl = path,
                IsAvailable = model.IsAvailable,
                Stock = model.Stock,
                User = model.User,
            };
        }

        public ProductViewModel ToProductViewModel(Product product)
        {
            return new ProductViewModel
            {
                Id = product.Id,
                Name = product.Name,
                LastPurchase = product.LastPurchase,
                LastSale = product.LastSale,
                Price = product.Price,
                ImageUrl = product.ImageUrl,
                IsAvailable = product.IsAvailable,
                Stock = product.Stock,
                User = product.User,
            };
        }
    }
}
