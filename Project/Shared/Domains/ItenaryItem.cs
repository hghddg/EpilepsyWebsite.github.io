using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Project.Shared.Domains
{
    public class ItenaryItem : BaseDomainModel,IValidatableObject
    {
        public DateTime Dateofhol{ get; set; }
        public float Price { get; set; }

        public virtual Country Country { get; set; }

        public int? CountryId { get; set; }

        public virtual Location Location { get; set; }

        public int? LocationId { get; set; }

        public virtual Attraction Attraction { get; set; }

        public int? AttractionId { get; set; }

        public virtual Hotel Hotel { get; set; }

        public int? HotelId { get; set; }
        
        public virtual Customer Customer { get; set; }

        public int? CustomerId { get; set; }

        public virtual Itenary Itenary { get; set; }

        public int? ItenaryId { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
          if (CountryId != LocationId)
          {
            if (AttractionId != LocationId)
            {
              if (HotelId != LocationId)
              {

                yield return new ValidationResult("Ensure all the locations are in the same place");
              }
            }
          }
        }
    }

}
