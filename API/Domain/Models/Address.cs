using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class Address
    {
        public int Id { get; set; }

        public string Street { get; set; }

        public string City { get; set; }

        public int CustomerId { get; set; }

        public Customer Customer { get; set; }
    }
}
