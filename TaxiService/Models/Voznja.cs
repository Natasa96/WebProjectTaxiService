using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaxiService.Models
{
    public class Voznja
    {
        int ID { get; set; }    //id preko kojeg cu prepoznavati voznju

        string Datum { get; set; }
        string Vreme { get; set; }
        Lokacija LGde { get; set; }
        Lokacija Odrediste { get; set; }
        double Iznos { get; set; }

        TipAutomobila Tip { get; set; }
        StatusVoznje Status { get; set; }

        Musterija m { get; set; }
        Dispecer d { get; set; }
        Vozac v { get; set; }
        Komentar k { get; set; }
    }
}