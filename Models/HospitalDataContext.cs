using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace SashaSrinivas_HospitalProject_01.Models
{
    public class HospitalDataContext : DbContext
    {
        public HospitalDataContext() : base("name=HospitalDataContext")
        {
        

        }

        public DbSet<News_events> News_events { get; set; }
        public DbSet<Payments> Payments { get; set; }


    }
}