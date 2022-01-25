using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Shared.Domains
{
    public class Customer : BaseDomainModel
    {
        public string Name { get; set; }

        public float Payment { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public string Contact { get; set; }

        public virtual Staff Staff { get; set; }

        public virtual List<Booking> Bookings { get; set; }
    }
}
