using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HEALTH.Data.Models
{
    public class PrestationSoin
    {
        public int Soin_ID { get; set; }
        public int Prestation_ID { get; set; }
        public int NbreSoin { get; set; }
        public virtual Soin Soin_ { get; set; }
        public virtual Prestation Prestation_ { get; set; }

    }
}
