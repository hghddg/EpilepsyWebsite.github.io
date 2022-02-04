using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Shared.Domains
{
    public class Hotel : BaseDomainModel
    {

        
        public string Name { get; set; }

        public double Rating { get; set; }

        public string Contact { get; set; }

        public string HLocation { get; set; }

        public float Price { get; set; }

        public virtual Location Location { get; set; }

        public int LocationID { get; set; }
    }
}
