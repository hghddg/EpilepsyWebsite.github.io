using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Shared.Domains
{
    public class Payment : BaseDomainModel
    {
        public string Plan { get; set; }

        public float Amount { get; set; }

        public string Description { get; set; }

        public string Type { get; set; }

    }
}
