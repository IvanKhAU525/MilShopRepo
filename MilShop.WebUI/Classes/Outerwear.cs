namespace MilShop.WebUI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Outerwear")]
    public partial class Outerwear
    {
        public int ID { get; set; }

        public short? Color { get; set; }

        public short? Size { get; set; }

        public int outrwr { get; set; }

        public short? Quantity { get; set; }

        public virtual Colors Colors { get; set; }

        public virtual OuterwearCategory OuterwearCategory { get; set; }

        public virtual Sizes Sizes { get; set; }
    }
}
