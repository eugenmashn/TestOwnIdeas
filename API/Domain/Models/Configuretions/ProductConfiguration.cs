using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models.Configuretions
{
    class ProductConfiguration
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
         
            builder
                .HasMany(p => p.CustomerProducts)
                .WithOne(cp => cp.Product)
                .HasForeignKey(cp => cp.ProductId);
        }
    }
}
