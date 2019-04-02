namespace PetsStore.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class dataContext : DbContext
    {
        public dataContext()
            : base("name=dataContext")
        {
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<orderDetail> orderDetails { get; set; }
        public virtual DbSet<OrderStore> OrderStores { get; set; }
        public virtual DbSet<Pet> Pets { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .HasMany(e => e.OrderStores)
                .WithRequired(e => e.Customer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrderStore>()
                .HasMany(e => e.orderDetails)
                .WithRequired(e => e.OrderStore)
                .HasForeignKey(e => e.orderId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Pet>()
                .HasMany(e => e.orderDetails)
                .WithRequired(e => e.Pet)
                .WillCascadeOnDelete(false);
        }
    }
}
