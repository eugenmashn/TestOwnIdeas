using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Domain.Models
{
    public class Membership
    {
        public Membership()
        {
            Customers = new Collection<Customer>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Customer> Customers { get; set; }
    }
}
