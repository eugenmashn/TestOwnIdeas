using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class MembershipModel
    {
        public MembershipModel() { }

        public MembershipModel(Membership membership) 
        {
            if (membership != null)
            { 
                Id = membership.Id;
                Name = membership.Name;
                Customers = membership.Customers != null ? membership.Customers.Select(m => new CustomerModel(m)).ToList() : null;
            }
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public List<CustomerModel> Customers { get; set; }
    }
}
