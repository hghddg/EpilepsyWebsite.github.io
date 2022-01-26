using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Shared.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Server.Configurations.Entities
{
    public class HotelSeedConfiguration : IEntityTypeConfiguration<Hotel>
    {
        public void Configure(EntityTypeBuilder<Hotel> builder)
        {
            builder.HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Taj Lands End",
                    Rating = 4.6,
                    Contact = "+91 22 6668 1234",
                    HLocation = "Band Stand, BJ Road, Mount Mary, Bandra West, Mumbai, Maharashtra 400050, India",
                    Price = 151.00F

                },

                new Hotel
                {
                    Id = 2,
                    Name = "Fairmont Beijing Hotel",
                    Rating = 4.4,
                    Contact = "+86 10 8511 7777",
                    HLocation = "China, Beijing, Chaoyang",
                    Price = 175.00F
                },

                new Hotel
                {
                    Id = 3,
                    Name = "Royal Tulip Brasília Alvorada",
                    Rating = 4.7,
                    Contact = "+55 61 3424-7000",
                    HLocation = "SHTN Trecho 1 Conjunto 1B Bloco C - Asa Norte, Brasília - DF, 70800-200, Brazil",
                    Price = 159.00F
                },

                new Hotel
                {
                    Id = 4,
                    Name = "Ramses Hilton",
                    Rating = 4.2,
                    Contact = "+20 2 25777444",
                    HLocation = "1115 Nile Corniche, Sharkas, Bulaq, Cairo Governorate, Egypt",
                    Price = 145.00F
                }


                );
        }
    }
}
