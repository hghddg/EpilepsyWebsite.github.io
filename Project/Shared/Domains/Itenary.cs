using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Shared.Domains
{
    public class Itenary : BaseDomainModel
    {
        public float TotalPrice { get; set; }

        public virtual ItenaryItem ItenaryItem { get; set; }

        public virtual List<Booking> Bookings { get; set; }

    }
}
