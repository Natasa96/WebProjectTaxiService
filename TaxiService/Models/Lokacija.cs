using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TaxiService.Models
{
    public class Lokacija
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public float x { get; set; }
        public float y { get; set; }
        public string ImeUlice { get; set; }
        public string Mesto { get; set; }
        public int PostanskiBr { get; set; }
        
        public Lokacija()
        {
            x = 0;
            y = 0;
            PostanskiBr = 0;
            ImeUlice = "";
            Mesto = "";
        }
    }
}