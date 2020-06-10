using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.DAL.Entities
{
    public class InvidualPerson
    {
        public int Id { get; set; }
        public string Full_name { get; set; }
        public int Passport_Code { get; set; }
        public int IHH { get; set; }
        public int Phone { get; set; }
        public string Adress { get; set; }

        public ICollection<Credit> Credits { get; set; }
        public ICollection<Deposit> Deposits { get; set; }
    }
}
