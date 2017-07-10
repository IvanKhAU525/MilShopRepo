namespace MilShop.WebUI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Quantity")]
    public partial class Quantity
    {
        [Key]
        public int Id_Quantity { get; set; }

        [Column("Quantity")]
        public short? Quantity1 { get; set; }
    }
}
