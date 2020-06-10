using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.DAL.Entities
{
    public class LegalPerson
    {
        public int Id { get; set; }
        public string Full_name { get; set; }
        public int Registration_IHH { get; set; }
        public string Adress { get; set; }

        public ICollection<Credit> Credits { get; set; }
        public ICollection<Deposit> Deposits { get; set; }
    }
}
