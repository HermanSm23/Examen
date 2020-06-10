using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.BLL.DTO
{
    public class LegalPersonDTO
    {
        public int Id { get; set; }
        public string Full_name { get; set; }
        public int Registration_IHH { get; set; }
        public string Adress { get; set; }
    }
}
