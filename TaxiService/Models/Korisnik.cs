using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using TaxiService.Models.Enum;

namespace TaxiService.Models
{
    public abstract class Korisnik
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual int ID { get; set; }

        public string kIme { get; set; }
        public string Lozinka { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Pol { get; set; }
        public double Jmbg { get; set; }
        public double Telefon { get; set; }
        public string Email { get; set; }
        public string Uloge { get; set; }
        string Voznja { get; set; }           //wft je ovo
    }
}