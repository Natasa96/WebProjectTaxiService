using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.Migrations;
using TaxiService.Models;
using TaxiService.Models.DB;

namespace TaxiService.App_Start
{
    public class DatabaseConfig : DbMigrationsConfiguration<DataAccess>
    {
        public DatabaseConfig()
        {
            AutomaticMigrationDataLossAllowed = true;
            AutomaticMigrationsEnabled = true;
            ContextKey = "TaxiServiceDB";
        }
    }
}