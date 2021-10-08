using aspMVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace aspMVCDemo.EF
{
    public class AspMVCDemoDbContext : DbContext
    {

        public AspMVCDemoDbContext() : base("aspMVCDemoDbConnection")
        {
        }

        // Account entity
        public virtual DbSet<Account> Accounts { get; set; }

        /*protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }*/

    }
}