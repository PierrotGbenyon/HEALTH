using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HEALTH.Data.Models
{
    public class Profil
    {
        public int ID { get; set; }
        public string Libelle { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
