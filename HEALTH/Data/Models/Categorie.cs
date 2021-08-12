using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HEALTH.Data.Models
{
    public class Categorie
    {
        public int ID { get; set; }
        public string Libelle { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Produit> Produits { get; set; }
    }
}
