using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Shared.Domains
{
    public class Staff : BaseDomainModel
    {
        public string Name { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Location Location { get; set; }
    }
}
