using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TaxiService.Models
{
    public class Vozac : Korisnik
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public override int ID { get; set; }    //ID za identifikaciju

        public Lokacija lokacija { get; set; }
        public int AutoID { get; set; }         //ID automobila

        public Vozac() : base()
        {
            AutoID = 0;
            lokacija = new Lokacija();
        }
    }
}