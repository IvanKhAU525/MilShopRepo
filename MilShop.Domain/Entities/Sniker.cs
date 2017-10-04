namespace MilShop.Domain.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sniker
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [StringLength(50)]
        public string ModelName { get; set; }

        public int? Color { get; set; }

        public int? Size { get; set; }

        public int? Price { get; set; }

        public int? Count { get; set; }

        public virtual Color Color1 { get; set; }

        public virtual Price Price1 { get; set; }

        public virtual Size Size1 { get; set; }
    }
}
