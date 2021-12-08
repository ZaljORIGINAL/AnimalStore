namespace AnimalsStoreWeb.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AnimalStore : DbContext
    {
        public AnimalStore()
            : base("name=AnimalStore")
        {
        }

        public virtual DbSet<orders> orders { get; set; }
        public virtual DbSet<shop_items> shop_items { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<orders>()
                .Property(e => e.fixed_price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<shop_items>()
                .Property(e => e.price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<shop_items>()
                .HasMany(e => e.orders)
                .WithRequired(e => e.shop_items)
                .HasForeignKey(e => e.shop_item_id)
                .WillCascadeOnDelete(false);
        }
    }
}
