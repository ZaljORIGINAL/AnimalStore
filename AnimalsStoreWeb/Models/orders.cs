namespace AnimalsStoreWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class orders
    {
        public long id { get; set; }

        [Required]
        [StringLength(128)]
        public string email { get; set; }

        public int shop_item_id { get; set; }

        public int count { get; set; }

        [Column(TypeName = "money")]
        public decimal fixed_price { get; set; }

        public byte status { get; set; }

        public virtual shop_items shop_items { get; set; }

        public string GetStatus()
        {
            switch (status)
            {
                case 1:
                    return "Отменен";
                
                case 2:
                    return "Заказан";
                
                case 3:
                    return "В процессе";
                
                case 4:
                    return "Завершен";
                
                default: return "Ошибка";
            }
        }
    }
}
