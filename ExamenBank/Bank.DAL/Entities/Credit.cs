using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.DAL.Entities
{
    public class Credit
    {
        public int Id { get; set; }
        public string Person_name { get; set; }
        public DateTime Duration { get; set; }
        public int Summ_percent { get; set; }
        public int Fine_percent { get; set; }

        public ICollection<InvidualPerson> InvidualPersons { get; set; }
        public ICollection<LegalPerson> LegalPersons { get; set; }
    }
}
