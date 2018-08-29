using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace TaxiService.Models
{
    public class DBAccess : DbContext
    {
        private static DBAccess data = null;

        public static DBAccess CreateDB()
        {
            if (data == null)
                data = new DBAccess();

            return data;
        }

        private DBAccess() : base("TaxiServiceDB") { }

        public virtual DbSet<Musterija> MusterijaDB { get; set; }
        public virtual DbSet<Vozac> VozacDB { get; set; }
        public virtual DbSet<Dispecer> DispecerDB { get; set; }
        public virtual DbSet<Komentar> KomentarDB { get; set; }
        public virtual DbSet<Automobil> AutomobilDB { get; set; }
        public virtual DbSet<Voznja> VoznjaDB { get; set; }
        public virtual DbSet<Lokacija> LokacijaDB { get; set; }
    }
}