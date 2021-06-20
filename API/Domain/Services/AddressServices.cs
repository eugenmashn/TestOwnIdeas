using Domain.Models;
using Domain.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Services
{
    public class AddressServices: Repository<Address>
    {
        public AddressServices(MyDbContext dbContext) : base(dbContext) { }

    }
}
