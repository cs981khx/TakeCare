using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace TakeCare.Api.DAL
{
    public class TakeCareContext: DbContext
    {
        public TakeCareContext() : base("TakeCareContext")
        {
        }

        public DbSet<Activity> Activities { get; set; }
        public DbSet<Care> Carers { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Device>  Devices{ get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}