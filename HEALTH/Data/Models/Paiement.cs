using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HEALTH.Data.Models
{
    public class Paiement
    {
        public int ID { get; set; }
        public string Libelle { get; set; }
        public int Solde { get; set; }
        public DateTime DatePaie { get; set; }
        public string Recu { get; set; }
        public int Prestation_ID { get; set; }
        public int CaisseOperation_ID { get; set; }
        public virtual Prestation Prestation_ { get; set; }
        public virtual CaisseOperation CaisseOperation_ { get; set; }


    }
}
