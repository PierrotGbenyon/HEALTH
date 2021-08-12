using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HEALTH.Data.Models
{
    public class AffectationCaisse
    {
        public int CaisseOperation_ID { get; set; }
        public int User_ID { get; set; }
        public DateTime dateAffectation { get; set; }
        public DateTime dateRetrait { get; set; }
        public virtual CaisseOperation CaisseOperation_ { get; set; }
        public virtual User User_ { get; set; }

    }
}
