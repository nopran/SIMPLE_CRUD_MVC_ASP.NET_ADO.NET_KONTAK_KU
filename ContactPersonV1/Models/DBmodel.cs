using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ContactPersonV1.Models
{
    public partial class DBmodel : DbContext
    {
        public DBmodel()
            : base("name=DBmodel")
        {
        }

        public virtual DbSet<TableCP> TableCPs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TableCP>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<TableCP>()
                .Property(e => e.PHONE)
                .IsUnicode(false);

            modelBuilder.Entity<TableCP>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<TableCP>()
                .Property(e => e.COMPANY)
                .IsUnicode(false);

            modelBuilder.Entity<TableCP>()
                .Property(e => e.COUNTRY)
                .IsUnicode(false);

            modelBuilder.Entity<TableCP>()
                .Property(e => e.ZIPCODE)
                .IsUnicode(false);

            modelBuilder.Entity<TableCP>()
                .Property(e => e.STATE)
                .IsUnicode(false);

            modelBuilder.Entity<TableCP>()
                .Property(e => e.CITY)
                .IsUnicode(false);

            modelBuilder.Entity<TableCP>()
                .Property(e => e.FOTO)
                .IsUnicode(false);
        }
    }
}
