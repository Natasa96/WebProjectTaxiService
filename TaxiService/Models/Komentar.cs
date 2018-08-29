using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaxiService.Models
{
    public class Komentar
    {
        int ID { get; set; } //nevidljivi id za prepoznavanje

        string Opis { get; set; }
        DateTime Datum { get; set; }
        int OcenaVoznje { get; set; }

        Korisnik K { get; set; }    //korisnik koji je ostavio komentar (da li cu moci da ga kastujem u vozaca a da svi parametri ostanu?)
        Voznja V { get; set; }      //voznja na koju je ostavljen komentar
    }
}