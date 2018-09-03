using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TaxiService.Models
{
    public class Komentar
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public string Opis { get; set; }
        public string Datum { get; set; }
        public int OcenaVoznje { get; set; }

        public int VoznjaID { get; set; }           //id voznje na koju se odnosi komentar
        public string Komentarisao { get; set; }    //ko je ostavio komentar
    }
}