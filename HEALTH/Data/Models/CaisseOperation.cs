using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HEALTH.Data.Models
{
    public class CaisseOperation
    {
        public int ID { get; set; }
        public string Libelle { get; set; }
        public DateTime DateOuverture { get; set; }
        public DateTime DateFermeture { get; set; }
        public int Solde { get; set; }
        public int FondCaisse { get; set; }
        public int Caisse_ID { get; set; }
        public virtual Caisse Caisse_ { get; set; }
        public virtual ICollection<Paiement> Paiements { get; set; }
        public virtual ICollection<AffectationCaisse> AffectationCaisses { get; set; }
        
    }
}
