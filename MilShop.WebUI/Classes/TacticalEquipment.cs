namespace MilShop.WebUI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TacticalEquipment")]
    public partial class TacticalEquipment
    {
        public int ID { get; set; }

        public short? Color { get; set; }

        public short? Size { get; set; }

        public int taceq { get; set; }

        public short? Quantity { get; set; }

        public virtual Colors Colors { get; set; }

        public virtual Sizes Sizes { get; set; }

        public virtual TacticalEquipmentCategory TacticalEquipmentCategory { get; set; }
    }
}
