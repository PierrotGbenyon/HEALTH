using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HEALTH.Data.Models
{
    public class Produit
    {
        public int ID { get; set; }
        public string Designation { get; set; }
        public int QteStock { get; set; }
        public int Seuil { get; set; }
        public int Prix { get; set; }
        public int Categorie_ID { get; set; }
        public virtual Categorie Categorie_ { get; set; }
        public  virtual ICollection<PrestationProduit> PrestationProduits { get; set; }


    }
}
