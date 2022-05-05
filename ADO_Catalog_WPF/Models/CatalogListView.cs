using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ADO_Catalog_WPF.Models
{
    public partial class CatalogListView : DbContext
    {
        public CatalogListView()
            : base("name=CatalogListView")
        {
        }

        public virtual DbSet<CategoryListView> CategoryListViews { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CategoryListView>()
                .Property(e => e.Category)
                .IsUnicode(false);

            modelBuilder.Entity<CategoryListView>()
                .Property(e => e.ProductName)
                .IsUnicode(false);
        }
    }
}
