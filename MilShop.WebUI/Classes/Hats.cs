namespace MilShop.WebUI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Hats
    {
        public int ID { get; set; }

        public short? Color { get; set; }

        public short? Size { get; set; }

        public int hat { get; set; }

        public short? Quantity { get; set; }

        public virtual HatsCategory HatsCategory { get; set; }

        public virtual Sizes Sizes { get; set; }
    }
}
