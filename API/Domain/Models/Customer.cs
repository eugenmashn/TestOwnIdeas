using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class Customer
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Address Address { get; set; }
        public int MembershipId { get; set; }

        public Membership Membership { get; set; }

        public ICollection<CustomerProduct> CustomerProducts { get; set; }
    }
}
