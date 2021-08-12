using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HEALTH.Data.Models
{
    public class Soin
    {
        public int ID { get; set; }
        public string Libelle { get; set; }
        public int Cout { get; set; }
        public int Type_ID { get; set; }
        public virtual TypeSoin TypeSoin_ { get; set; }
        public virtual ICollection<PrestationSoin> PrestationSoins { get; set; }
    }
}
