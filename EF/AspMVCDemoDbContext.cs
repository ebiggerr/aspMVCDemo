using aspMVCDemo.Models.Account;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using aspMVCDemo.Models.Roles;
using AutoMapper;
using Profile = aspMVCDemo.Models.Profile.Profile;

namespace aspMVCDemo.EF
{
    public class AspMVCDemoDbContext : DbContext
    {

        public AspMVCDemoDbContext() : base("aspMVCDemoDbConnection")
        {
        }

        // Account entity
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Profile> Profiles { get; set; }

        public virtual DbSet<Role> Roles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            
            modelBuilder.Entity<Account>()
                .HasIndex(x => x.Username)
                .IsUnique();
            modelBuilder.Entity<Account>()
                .Property(x => x.Username)
                .IsRequired();
            modelBuilder.Entity<Account>()
                .Property(x => x.Password)
                .IsRequired();
            
            // Configure the primary key for the Account
            modelBuilder.Entity<Account>()
                .HasKey(t => t.Id);

            //Each Profile will belongs to an account (One-to-One)
            //Profile_Id (Account) <--> Id (Profile) long data type
            modelBuilder.Entity<Profile>()
                .HasRequired(t => t.Account)
                .WithRequiredPrincipal(t => t.Profile);
            
            modelBuilder.Entity<Account>()
                .HasMany(acc => acc.Roles)
                .WithMany(r => r.Accounts)
                .Map(m =>
                {
                    m.ToTable("AccountRoles");
                    m.MapLeftKey("AccountId");
                    m.MapRightKey("RoleId");
                });

        }

        

    }
}