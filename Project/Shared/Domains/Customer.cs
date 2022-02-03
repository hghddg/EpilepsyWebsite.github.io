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

        public string Staff { get; set; }

        public virtual List<Booking> Bookings { get; set; }

        //public string FirstName { get; set; }
        //public string LastName { get; set; }
        //public string Contact { get; set; }
        //public string Email { get; set; }
        //public string Address { get; set; }
    }
}
