using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Shared.Domains
{
   public class Attraction : BaseDomainModel
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string ALocation { get; set; }

        public float Price { get; set; }

        public virtual Location Location { get; set; }

        public int LocationID { get; set; }
    }
}
