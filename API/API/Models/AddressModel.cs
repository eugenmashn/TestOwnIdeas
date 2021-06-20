using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class AddressModel
    {
        public AddressModel() { }

        public AddressModel(Address address)
        {
            Id = address.Id;
            Street = address.Street;
            City = address.City;
        }
        public int Id { get; set; }

        public string Street { get; set; }

        public string City { get; set; }

    }
}
