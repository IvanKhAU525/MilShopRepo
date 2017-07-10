namespace MilShop.WebUI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Uniforms
    {
        public int ID { get; set; }

        public short? Color { get; set; }

        public short? Size { get; set; }

        public int uniform { get; set; }

        public short? Quantity { get; set; }

        public virtual Colors Colors { get; set; }

        public virtual Sizes Sizes { get; set; }

        public virtual UniformsCategory UniformsCategory { get; set; }
    }
}
