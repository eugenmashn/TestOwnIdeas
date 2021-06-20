using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class CustomerModel
    {
        public CustomerModel() { }
        
        public CustomerModel(Customer customer) 
        {
            if(customer != null)
            {
                Id = customer.Id;
                Name = customer.Name;
                Address = customer.Address != null ? new AddressModel(customer.Address) : null;
                Membership = customer.Membership != null ? new MembershipModel(customer.Membership) : null;
                CustomerProducts = customer.CustomerProducts != null ? customer.CustomerProducts.Select( c => new CustomerProductModel(c)).ToList() : null;

            }
            
        }


        public int Id { get; set; }

        public string Name { get; set; }

        public AddressModel Address { get; set; }
        public int MembershipId { get; set; }

        public MembershipModel Membership { get; set; }

        public List<CustomerProductModel> CustomerProducts { get; set; }
    }
}
