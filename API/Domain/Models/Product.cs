using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Domain.Models
{
    public class Product
    {
        public Product()
        {
            CustomerProducts = new Collection<CustomerProduct>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public int Price { get; set; }

        public ICollection<CustomerProduct> CustomerProducts { get; set; }
    }
}
