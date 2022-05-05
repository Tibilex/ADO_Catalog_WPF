namespace ADO_Catalog_WPF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProductBlockButton")]
    public partial class ProductBlockButton
    {
        public int id { get; set; }

        [Required]
        [StringLength(150)]
        public string ProductName { get; set; }

        public int Price { get; set; }

        [Required]
        [StringLength(50)]
        public string ProductBlock { get; set; }
    }
}
