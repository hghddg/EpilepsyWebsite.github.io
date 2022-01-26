using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Shared.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Server.Configurations.Entities
{
    public class AttractionSeedConfiguration : IEntityTypeConfiguration<Attraction>
    {
        public void Configure(EntityTypeBuilder<Attraction> builder)
        {
            builder.HasData(
                new Attraction
                {
                    Id = 1,
                    Name = "Kanheri Caves",
                    Description = "The Kanheri Caves are a group of caves and rock-cut monuments cut into a massive basalt outcrop in the forests of the Sanjay Gandhi National Park, " +
                    "on the former island of Salsette in the western outskirts of Mumbai, India ",
                    ALocation = "Mumbai, Maharashtra 400101, India",
                    Price = 3.59F,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },

                new Attraction
                {
                    Id = 2,
                    Name = "Great Wall of China",
                    Description = "The Great Wall of China is a series of fortifications that were built across the historical northern borders of ancient Chinese states " +
                    "and Imperial China as protection against various nomadic groups from the Eurasian Steppe ",
                    ALocation = "Huairou District, China, 101406",
                    Price = 21.28F,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },

                new Attraction
                {
                    Id = 3,
                    Name = "Santuário São João Bosco",
                    Description = "From the outside, the Dom Bosco Sanctuary looks like barely more than a mildly impressive concrete block. " +
                    "However, entry to this beloved monument reveals a remarkable space filled with heavenly blue light and stunning architectural feats. " +
                    "Take a moment to experience the unique beauty of this building and pay tribute to St. Dom Bosco.",
                    ALocation = "Quadra 702 Sul Bloco B, SHCS, Brasília - DF, Brazil",
                    Price = 0,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },

                new Attraction
                {
                    Id = 4,
                    Name = "The Great Pyramid of Giza",
                    Description = "The Great Pyramid of Giza is the oldest and largest of the pyramids in the Giza pyramid complex" +
                    "bordering present-day Giza in Greater Cairo, Egypt. It is the oldest of the Seven Wonders of the Ancient World,",
                    ALocation = "Al Haram, Nazlet El-Semman, Al Giza Desert, Giza Governorate, Egypt",
                    Price = 45.75F,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }

                ) ;
        }
    }
}
