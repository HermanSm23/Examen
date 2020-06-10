using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamenBank.Models
{
    public class LegalPersonViewModel
    {
        public int Id { get; set; }
        public string Full_name { get; set; }
        public int Registration_IHH { get; set; }
        public string Adress { get; set; }
    }
}