namespace AnimalsStoreWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ShopItem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ShopItem()
        {
            orders = new HashSet<Order>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(128)]
        public string name { get; set; }

        [Required]
        [StringLength(512)]
        public string description { get; set; }

        [Column(TypeName = "money")]
        public decimal price { get; set; }

        [Required]
        public byte[] image { get; set; }

        public bool visible { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> orders { get; set; }
    }
}
