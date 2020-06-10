using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamenBank.Models
{
    public class CreditViewModel
    {
        public int Id { get; set; }
        public string Person_name { get; set; }
        public DateTime Duration { get; set; }
        public int Summ_percent { get; set; }
        public int Fine_percent { get; set; }
    }
}