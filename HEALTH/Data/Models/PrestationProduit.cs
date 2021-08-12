using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HEALTH.Data.Models
{
    public class PrestationProduit
    {
        public int Produit_ID { get; set; }
        public int Prestation_ID { get; set; }
        public int Qte { get; set; }
        public virtual Produit Produit_ { get; set; }
        public virtual Prestation Prestation_ { get; set; }
    }
}
