using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaxiService.Models
{
    public class Automobil
    {
        int GodisteAutomobila { get; set; }
        string Registracija { get; set; }   
        int BrojTaxija { get; set; }     //id za prepoznavanje automobila

        Vozac v { get; set; }
        TipAutomobila Tip { get; set; }
    }
}