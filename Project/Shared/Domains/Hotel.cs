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
    }
}
