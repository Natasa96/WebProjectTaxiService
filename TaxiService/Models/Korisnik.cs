using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TaxiService.Models.Enum;

namespace TaxiService.Models
{
    public abstract class Korisnik
    {
        string kIme { get; set; }
        string Lozinka { get; set; }
        string Ime { get; set; }
        string Prezime { get; set; }
        enum Pol { MUSKI, ZENSKI};
        double Jmbg { get; set; }
        double Telefon { get; set; }
        string Email { get; set; }
        Uloga Uloge { get; set; }
        string Voznja { get; set; }           //wft je ovo
    }
}