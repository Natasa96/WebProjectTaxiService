using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaxiService.Models
{
    public class Vozac : Korisnik
    {
        int ID { get; set; }    //ID za identifikaciju

        Lokacija lokacija { get; set; }
        Automobil automobil { get; set; }
    }
}