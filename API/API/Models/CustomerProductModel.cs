using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class CustomerProductModel
    {
        public CustomerProductModel() { }

        public CustomerProductModel(CustomerProduct customerProduct)
        {
            if(customerProduct != null)
            {
                Customer = customerProduct.Customer != null ? new CustomerModel(customerProduct.Customer) : null;
                Product = customerProduct.Product != null ? new ProductModel(customerProduct.Product) : null;
            }
        }

        public CustomerModel Customer { get; set; }

        public ProductModel Product { get; set; }
    }
}
