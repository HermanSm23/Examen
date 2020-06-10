using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamenBank.Models
{
    public class InvidualPersonViewModel
    {
        public int Id { get; set; }
        public string Full_name { get; set; }
        public int Passport_Code { get; set; }
        public int IHH { get; set; }
        public int Phone { get; set; }
        public string Adress { get; set; }
    }
}