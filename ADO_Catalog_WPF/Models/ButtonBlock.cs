using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ADO_Catalog_WPF.Models
{
    public partial class ButtonBlock : DbContext
    {
        public ButtonBlock()
            : base("name=ButtonBlock")
        {
        }

        public virtual DbSet<ProductBlockButton> ProductBlockButtons { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductBlockButton>()
                .Property(e => e.ProductName)
                .IsUnicode(false);

            modelBuilder.Entity<ProductBlockButton>()
                .Property(e => e.ProductBlock)
                .IsUnicode(false);
        }
    }
}
