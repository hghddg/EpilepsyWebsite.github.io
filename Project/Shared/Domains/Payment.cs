using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Shared.Domains
{
    public class Payment : BaseDomainModel
    {
        public float Amount { get; set; }

        public string Type { get; set; }

        public DateTime Date { get; set; }

    }
}
