namespace MilShop.WebUI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OuterwearCategory")]
    public partial class OuterwearCategory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OuterwearCategory()
        {
            Outerwear = new HashSet<Outerwear>();
        }

        [Key]
        public int Id_Outerwear { get; set; }

        [StringLength(30)]
        public string Name { get; set; }

        public short? Price { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Outerwear> Outerwear { get; set; }
    }
}
