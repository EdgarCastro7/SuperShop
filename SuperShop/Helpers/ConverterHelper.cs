using SuperShop.Data.Entities;
using SuperShop.Models;
using System;

namespace SuperShop.Helpers
{
    public class ConverterHelper : IConverterHelper
    {
        public Product ToProduct(ProductViewModel model,Guid imageId, bool isNew)
        {
            return new ProductViewModel
            {
                Id = isNew ? 0 : model.Id,
                Name = model.Name,
                LastPurchase = model.LastPurchase,
                LastSale = model.LastSale,
                Price = model.Price,
                ImageId = imageId,
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
                ImageId = product.ImageId,
                IsAvailable = product.IsAvailable,
                Stock = product.Stock,
                User = product.User,
            };
        }
    }
}
