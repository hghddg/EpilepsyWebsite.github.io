using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Shared.Domains
{
    public class ItenaryItem : BaseDomainModel
    {
        public float Price { get; set; }

        public virtual Attraction Attraction { get; set; }

        public virtual Hotel Hotel { get; set; }

        public virtual Itenary Itenary { get; set; }
    }
}
