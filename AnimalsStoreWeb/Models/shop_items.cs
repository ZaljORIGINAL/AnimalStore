using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;
using System.Drawing;
using System.IO;

namespace AnimalsStoreWeb.Models
{
    public partial class shop_items
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public shop_items()
        {
            orders = new HashSet<orders>();
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
        public virtual ICollection<orders> orders { get; set; }

        public Image GetImage()
        {
            MemoryStream ms = new MemoryStream(image);
            Image img = Image.FromStream(ms);
            Size size = new Size(100, 100);
            return new Bitmap(img, size);
        }
    }
}
