﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web;
using TaxiService.Models;
using TaxiService.Models.DB;
using TaxiService.Models.Enum;

namespace TaxiService.App_Start
{
    public class AdminConfig
    {

        private static DataAccess db = DataAccess.CreateDb();

        public static void LoadAdmins()
        {
                                                            //putanja do txt fajla odakle se ucitava admin
            using (StreamReader reader = new StreamReader(@"D:\FAX\WEB\TaxiService\TaxiService\App_Start\AdminConfig.txt")) 
            {
                string info = reader.ReadLine();
                if (!string.IsNullOrEmpty(info))
                {
                    string[] parts = info.Split(',');
                    if (!db.DispacherDb.ToList().Exists(p => p.Username == parts[0]))
                    {
                        db.DispacherDb.Add(new Dispacher()
                        {
                            Username = parts[0],
                            Password = parts[1],
                            Firstname = parts[2],
                            Lastname = parts[3],
                            JMBG = parts[4],
                            Gender = parts[5],
                            Email = parts[6],
                            ContactPhone = Int32.Parse(parts[7]),
                            Role = UserRole.DispacherRole,
                            RideList = null
                        });
                        db.UserDb.Add(new Models.DB.LoginBase()
                        {
                            Username = parts[0],
                            Password = parts[1],
                            Role = UserRole.DispacherRole
                        });
                    }
                }
            }
            db.SaveChanges();
        }
    }
}