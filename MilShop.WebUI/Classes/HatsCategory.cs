namespace MilShop.WebUI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HatsCategory")]
    public partial class HatsCategory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HatsCategory()
        {
            Hats = new HashSet<Hats>();
        }

        [Key]
        public int Id_Hat { get; set; }

        [StringLength(30)]
        public string Name { get; set; }

        public short? Price { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Hats> Hats { get; set; }
    }
}
