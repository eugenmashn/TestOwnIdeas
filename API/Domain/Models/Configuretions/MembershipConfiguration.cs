using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models.Configuretions
{
    public class MembershipConfiguration : IEntityTypeConfiguration<Membership>
    {
        public void Configure(EntityTypeBuilder<Membership> builder)
        {
          

            builder
                .HasMany(m => m.Customers)
                .WithOne(c => c.Membership)
                .HasForeignKey(c => c.MembershipId);
        }
    }
}
