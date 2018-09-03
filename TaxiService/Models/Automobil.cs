using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TaxiService.Models
{
    public class Automobil
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public int GodisteAutomobila { get; set; }
        public string Registracija { get; set; }   
        public int BrojTaxija { get; set; }    
        public int VozacID { get; set; }
        public string TipA { get; set; }
    }
}