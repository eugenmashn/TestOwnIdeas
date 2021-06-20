using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class ProductModel
    {
        public ProductModel() { }

        public ProductModel(Product product)
        {
            if(product != null)
            {
                Id = product.Id;
                Name = product.Name;
                Price = product.Price;
                CustomerProducts = product.CustomerProducts != null ? product.CustomerProducts.Select(p => new CustomerProductModel(p)).ToList() : null;
            }
            
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public int Price { get; set; }

        public List<CustomerProductModel> CustomerProducts { get; set; }
    }
}
