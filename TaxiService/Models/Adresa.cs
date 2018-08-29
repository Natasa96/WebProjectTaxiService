using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaxiService.Models
{
    public class Adresa
    {
        string ulica { get; set; }
        int broj { get; set; }
        string mesto { get; set; }
        string postanskiBr { get; set; }

        public override string ToString()
        {
            return ulica + " " + broj.ToString() + ", " + mesto + " " + postanskiBr.ToString();
        }
    }
}