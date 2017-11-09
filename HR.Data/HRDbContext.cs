using HR.Core.Models.Master;
using HR.Core.Models.Security;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Data
{
    public class HRDbContext:DbContext
    {
        public HRDbContext() : base("name=HRContext")
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Users>().HasKey<string>(u => u.UserID);
            #region Master DB Schema
            modelBuilder.Entity<Company>().ToTable("Companies", "Master");
            modelBuilder.Entity<Country>().ToTable("Countries", "Master");
            modelBuilder.Entity<Address>().ToTable("Addresses", "Master");
            modelBuilder.Entity<Branch>().ToTable("Branches", "Master");
            modelBuilder.Entity<HolidayList>().ToTable("HolidayLists", "Master");
            modelBuilder.Entity<Users>().ToTable("Users", "Security");
            modelBuilder.Entity<LookUp>().ToTable("LookUp", "Config");
            #endregion
        }

        #region DbSetClasses

        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<Branch> Branches { get; set; }

        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<HolidayList> HolidayLists { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        public virtual DbSet<LookUp> LookUps { get; set; }
        #endregion
    }
}
