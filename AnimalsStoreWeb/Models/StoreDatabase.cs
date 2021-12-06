namespace AnimalsStoreWeb.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class StoreDatabase : DbContext
    {
        public StoreDatabase()
            : base("name=StoreDatabase")
        {
        }

        public virtual DbSet<Order> orders { get; set; }
        public virtual DbSet<ShopItem> shop_items { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>()
                .Property(e => e.fixed_price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ShopItem>()
                .Property(e => e.price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ShopItem>()
                .HasMany(e => e.orders)
                .WithRequired(e => e.shop_items)
                .HasForeignKey(e => e.shop_item_id)
                .WillCascadeOnDelete(false);
        }
    }
}
