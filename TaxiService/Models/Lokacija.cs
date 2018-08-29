using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaxiService.Models
{
    public class Lokacija
    {
        float x { get; set; }
        float y { get; set; }

        Adresa addr { get; set; }     //adresa odredista u odredjenom formatu
    }
}