using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Shared.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Server.Configurations.Entities
{
    public class CountrySeedConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasData(
                      new Country
                      {
                          Id = 1,
                          Name = "India",
                          Detail = "The people of India are known for their traditions of hospitality to foreigners. " +
                          "They have varied life styles, cultural heritage and colourful fairs and festivals. " +
                          "Which make India a unique tourist destination. " +
                          "India abounds in attractive and well-preserved historical sites, " +
                          "ancient monuments of architectural grandeur and not-so-ancient mosques/durgahs, " +
                          "churches and places of worship of other diverse faiths",
                          DateCreated = DateTime.Now,
                          DateUpdated = DateTime.Now,
                          CreatedBy = "System",
                          UpdatedBy = "System"
                      },

                      new Country
                      {
                          Id = 2,
                          Name = "China",
                          Detail = "It has everything that can be interesting to a foreigner: " +
                          "architectural monuments of one of the most ancient civilizations, " +
                          "national parks with different climate and nature, " +
                          "modern metropolises and small provincial towns which managed to preserve their original culture, " +
                          "amazing sand beaches and inaccessible snow-white mountain tops.",
                          DateCreated = DateTime.Now,
                          DateUpdated = DateTime.Now,
                          CreatedBy = "System",
                          UpdatedBy = "System"
                      },

                      new Country
                      {
                          Id = 3,
                          Name = "Brazil",
                          Detail = "Most tourists in Brazil travel to Rio de Janeiro " +
                          "and other easily accessible sites that are in or around urban centres with well-established hospitality industries. " +
                          "Salvador and other parts of Bahia are major tourist attractions, " +
                          "and increasing numbers of vacationers are visiting other coastal areas of the Northeast. " +
                          "Eco-tourism is moderately popular in the Amazon region, " +
                          "while in the South the beaches of Santa Catarina draw large crowds of Argentine tourists.",
                          DateCreated = DateTime.Now,
                          DateUpdated = DateTime.Now,
                          CreatedBy = "System",
                          UpdatedBy = "System"
                      },

                      new Country
                      {
                          Id = 4,
                          Name = "Egypt",
                          Detail = "Egypt is the best-known tourist destination in the Middle East as it has a magnificent history," +
                          " a timeless civilization of more than 5000 years with a huge variety of an endless number of antiquities, artifacts, and monuments. " +
                          "The Ancient Egypt Civilization has many hidden secrets which need to be revealed " +
                          "and that’s why, Many thousands of tourists from all over the world enjoy Egypt",
                          DateCreated = DateTime.Now,
                          DateUpdated = DateTime.Now,
                          CreatedBy = "System",
                          UpdatedBy = "System"

                      }

                      );
        }
    }
}
