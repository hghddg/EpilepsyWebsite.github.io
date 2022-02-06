using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Shared.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Server.Configurations.Entities
{
    public class PaymentSeedConfiguration : IEntityTypeConfiguration<Payment>
    {
        public void Configure(EntityTypeBuilder<Payment> builder)
        {
            builder.HasData(
                    
                    new Payment
                    {
                        Id = 1,
                        Plan = "Normal Package",
                        Amount = 350F,
                        Description = "The Standard Package includes all of the necessary items" +  
                        "Also includes a goodie bag which has complementary vouchers, a pen, shirt and some toiletries" +
                        "To kickstart your journey with us.",
                        Type = "Debit, Credit.",
                        DateCreated = DateTime.Now,
                        DateUpdated = DateTime.Now,
                        CreatedBy = "System",
                        UpdatedBy = "System"
                    },

                    new Payment
                    {
                        Id = 2,
                        Plan = "Exclusive Package",
                        Amount = 780F,
                        Description = "The Exclusive Package includes items which will make u feel like a King or a Queen" +
                        "It includes free transport for about 10 times, A 300 subsidy for your needs, goodie bad and 2 free tickets for an additional attraction" +
                        "Having this plan will make your travel a time to remember",
                        Type = "Debit, Credit.",
                        DateCreated = DateTime.Now,
                        DateUpdated = DateTime.Now,
                        CreatedBy = "System",
                        UpdatedBy = "System"
                    }

                );
        }
    }
}
