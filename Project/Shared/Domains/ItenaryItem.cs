using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Shared.Domains
{
    public class ItenaryItem : BaseDomainModel
    {
        public DateTime Dateofhol{ get; set; }
        public float Price { get; set; }

        public virtual Country Country { get; set; }

        public int CountryId { get; set; }

        public virtual Location Location { get; set; }

        public int LocationId { get; set; }

        public virtual Attraction Attraction { get; set; }

        public int AttractionId { get; set; }

        public virtual Hotel Hotel { get; set; }

        public int HotelId { get; set; }
        
        public virtual Customer Customer { get; set; }

        public int CustomerId { get; set; }

        public virtual Itenary Itenary { get; set; }

    }
}
