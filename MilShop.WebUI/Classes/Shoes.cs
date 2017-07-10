namespace MilShop.WebUI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Shoes
    {
        public int ID { get; set; }

        public short? Color { get; set; }

        public short? Size { get; set; }

        [Column("shoes")]
        public int shoes1 { get; set; }

        public short? Quantity { get; set; }

        public virtual Colors Colors { get; set; }

        public virtual ShoesCategory ShoesCategory { get; set; }

        public virtual Sizes Sizes { get; set; }
    }
}
