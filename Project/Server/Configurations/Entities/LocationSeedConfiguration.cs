using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Shared.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Server.Configurations.Entities
{
    public class LocationSeedConfiguration : IEntityTypeConfiguration<Location>
    {
        public void Configure(EntityTypeBuilder<Location> builder)
        {
            builder.HasData(
                      new Location
                      {
                          Id = 1,
                          Name = "Mumbai",
                          Detail = "If you are planning to visit Mumbai, " +
                          "trust us when we say it may look intimidating initially, but it is not. " +
                          "In fact it is one of the friendliest cities of India. The extreme energy and the fast paced life of the people here cannot be easily matched. " +
                          "The heart of Mumbai has some of the best and beautiful colonial architecture and if you venture out to the lesser known lanes, " +
                          "you will also come across several distinct bazaars, temples, fancy restaurants and a nightlife that is one of its kinds.",
                          CountryId = 1,
                          DateCreated = DateTime.Now,
                          DateUpdated = DateTime.Now,
                          CreatedBy = "System",
                          UpdatedBy = "System"
                      },

                      new Location
                      {
                          Id = 2,
                          Name = "Beijing",
                          Detail = "From Peking opera troupes to world-class contemporary art," +
                          " Beijing draws on a profound well of creativity, and that's despite the vagaries of censorship. " +
                          "To give the government its due, museums are more numerous than ever, " +
                          "curation is less prescriptive and innovation is at an all-time high.",
                          DateCreated = DateTime.Now,
                          DateUpdated = DateTime.Now,
                          CountryId = 2,
                          CreatedBy = "System",
                          UpdatedBy = "System"
                      },

                      new Location
                      {
                          Id = 3,
                          Name = "Brasília",
                          Detail = "With long distances and harrowing six-lane highways connected by spaghetti junctions, " +
                          "Brasília presents challenges for walkers; consider renting a car or ride shares." +
                          "You'll find a lively city hidden behind the futuristic facade. " +
                          "It's not only a pilgrimage for architecture buffs but" +
                          " also foodies, night owls and those seeking a unique travel experience.",
                          DateCreated = DateTime.Now,
                          DateUpdated = DateTime.Now,
                          CountryId = 3,
                          CreatedBy = "System",
                          UpdatedBy = "System"
                      },

                      new Location
                      {
                          Id = 4,
                          Name = "Cairo",
                          Detail = "Cairo is one of the world's great megacities. " +
                          "As beautiful and as rich in historic finery as it is confounding and an assault on your senses to first-time visitors " +
                          "The main tourist attraction everyone is here to see are the Giza Pyramids on the city's doorstep, " +
                          "but the city itself is crammed with major monuments that span centuries of history. " +
                          "There are so many things to do in Cairo that you'll only be able to cover a sliver on one trip.",
                          DateCreated = DateTime.Now,
                          DateUpdated = DateTime.Now,
                          CountryId = 4,
                          CreatedBy = "System",
                          UpdatedBy = "System"

                      }

                      );
        }
    }
}
