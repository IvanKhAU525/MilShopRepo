namespace MilShop.WebUI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Pants
    {
        public int ID { get; set; }

        public short? Color { get; set; }

        public short? Size { get; set; }

        [Column("pants")]
        public int pants1 { get; set; }

        public short? Quantity { get; set; }

        public virtual Colors Colors { get; set; }

        public virtual PantsCategory PantsCategory { get; set; }

        public virtual Sizes Sizes { get; set; }
    }
}
