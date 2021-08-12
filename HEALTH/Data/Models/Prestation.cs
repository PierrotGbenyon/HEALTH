using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HEALTH.Data.Models
{
    public class Prestation
    {
        public int ID { get; set; }
        public string Libelle { get; set; }
        public virtual ICollection<PrestationProduit> PrestationProduits { get; set; }
        public virtual ICollection<PrestationSoin> PrestationSoins { get; set; }
        public virtual ICollection<Paiement> Paiements { get; set; }
    }
}
