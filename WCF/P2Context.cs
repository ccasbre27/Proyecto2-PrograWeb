﻿
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCF
{
    public class P2Context : DbContext
    {
        public DbSet<Entities.Product> Products { get; set; }

        public DbSet<Entities.User> Users { get; set; }

        public DbSet<Entities.UserType> UserTypes { get; set; }

        public P2Context() : base("P2ConnectionString")
        {
            Database.SetInitializer<P2Context>(new DropCreateDatabaseIfModelChanges<P2Context>());
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}
