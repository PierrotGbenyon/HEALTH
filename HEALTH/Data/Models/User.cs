using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HEALTH.Data.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Adresse { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string firstUse { get; set; }
        public int Profil_ID { get; set; }
        public virtual Profil Profil_ { get; set; }
        public virtual ICollection<AffectationCaisse> AffectationCaisses { get; set; }

    }
}
