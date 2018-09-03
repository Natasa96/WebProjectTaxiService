using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TaxiService.Models
{
    public class Voznja
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }    //id preko kojeg cu prepoznavati voznju

        public string VremeNarudzbe { get; set; }
        public Lokacija LGde { get; set; }      //lokacija gde dolazi taxi
        public Lokacija Odrediste { get; set; }
        public double Iznos { get; set; }

        public string TipA { get; set; }
        public string StatusVoznje { get; set; }

        public int mID { get; set; }        //id musterije
        public int dID { get; set; }        //id dispecera
        public int vID { get; set; }        //id vozaca
        public int kID { get; set; }        //id komentara
    }
}