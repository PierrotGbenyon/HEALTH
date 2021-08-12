using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HEALTH.Data.Models
{
    public class Caisse
    {
        public int ID { get; set; }
        public string NomCaisse { get; set; }
        public virtual ICollection<CaisseOperation> CaisseOperations { get; set; }

    }
}
