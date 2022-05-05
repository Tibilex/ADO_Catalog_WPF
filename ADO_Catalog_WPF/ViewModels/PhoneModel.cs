using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ADO_Catalog_WPF.Models
{
    public partial class PhoneModel : DbContext
    {
        public PhoneModel()
            : base("name=PhoneModel")
        {
        }

        public virtual DbSet<SmartPhone> SmartPhones { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SmartPhone>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<SmartPhone>()
                .Property(e => e.Company)
                .IsUnicode(false);
        }
    }
}
