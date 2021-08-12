using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HEALTH.Data.Models
{
    public class TypeSoin
    {
        public int ID { get; set; }
        public string Libelle { get; set; }
        public virtual ICollection<Soin> Soins { get; set; }
    }
}
